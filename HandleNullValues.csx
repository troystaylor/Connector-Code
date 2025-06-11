using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Script : ScriptBase
{
    public override async Task<HttpResponseMessage> ExecuteAsync()
    {
        var response = await this.Context.SendAsync(this.Context.Request, this.CancellationToken).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!string.IsNullOrEmpty(responseString))
            {
                var transformedJson = ConvertNullsToEmptyStrings(responseString);
                response.Content = CreateJsonContent(transformedJson);
            }
        }

        return response;
    }

    private string ConvertNullsToEmptyStrings(string jsonString)
    {
        if (string.IsNullOrEmpty(jsonString))
            return jsonString;
        try
        {
            var token = JToken.Parse(jsonString);
            ProcessToken(token);
            return token.ToString(Newtonsoft.Json.Formatting.None);
        }
        catch (JsonReaderException)
        {
            return jsonString;
        }
    }
    private void ProcessToken(JToken token)
    {
        switch (token.Type)
        {
            case JTokenType.Object:
                var typeCache = new Dictionary<string, JTokenType>();

                if (token.Root.Type == JTokenType.Array)
                {
                    BuildTypeCache(token.Root, typeCache);
                }

                foreach (var property in token.Children<JProperty>().ToList())
                {
                    if (property.Value.Type == JTokenType.Null)
                    {
                        if (property.Name.EndsWith("_id"))
                        {
                            property.Remove();
                        }
                        else if (typeCache.TryGetValue(property.Name, out var cachedType))
                        {
                            if (cachedType == JTokenType.Boolean)
                            {
                                property.Remove();
                            }
                            else
                            {
                                property.Value = GetDefaultForType(cachedType);
                            }
                        }
                        else
                        {
                            property.Value = "";
                        }
                    }
                    else
                    {
                        ProcessToken(property.Value);
                    }
                }
                break;

            case JTokenType.Array:
                foreach (var item in token.Children().ToList())
                {
                    if (item.Type == JTokenType.Null)
                    {
                        item.Replace("");
                    }
                    else
                    {
                        ProcessToken(item);
                    }
                }
                break;
        }
    }

    private void BuildTypeCache(JToken root, Dictionary<string, JTokenType> typeCache)
    {
        foreach (var item in root.Children())
        {
            if (item.Type == JTokenType.Object)
            {
                foreach (var prop in item.Children<JProperty>())
                {
                    if (prop.Value.Type != JTokenType.Null && !typeCache.ContainsKey(prop.Name))
                    {
                        typeCache[prop.Name] = prop.Value.Type;
                    }
                }
            }
        }
    }

    private JToken GetDefaultForType(JTokenType tokenType)
    {
        switch (tokenType)
        {
            case JTokenType.Integer:
            case JTokenType.Float:
                return 0;
            case JTokenType.String:
                return "";
            case JTokenType.Array:
                return new JArray();
            case JTokenType.Object:
                return new JObject();
            default:
                return "";
        }
    }
}
