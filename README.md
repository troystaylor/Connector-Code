# Connector Code
This repo contains script files that will work with Power Platform connectors.

### [Bearer Token Authorization](https://github.com/troystaylor/Connector-Code/tree/main/Bearer%20Token%20Authorization)
This custom code works with the API Key security method when the parameter name is set to Authorization. It removes the need to ask the user to enter "Bearer " before the token value.

### [Convert String to Hash](https://github.com/troystaylor/Connector-Code/tree/main/Convert%20String%20to%20Hash)
This custom code converts a string to a hash using MD5, SHA1, SHA256, or SHA512 algorithms. The script takes a string and hash type as input and returns the hashed value.

### [Download File without Connector Authorization](https://github.com/troystaylor/Connector-Code/tree/main/Download%20File%20without%20Connector%20Authorization)
This custom code downloads a file from a URL provided as a query parameter, bypassing the connector's standard authorization. Useful for downloading files from URLs that don't require the connector's credentials.

### [Escape HTML Response](https://github.com/troystaylor/Connector-Code/tree/main/EscapeHTMLResponse)
This custom code removes unwanted HTML elements from an API response. Specifically designed to strip social media widgets and GitHub buttons from weather API responses (wttr.in), making the response cleaner for display.

### [JWT Authentication](https://github.com/troystaylor/Connector-Code/tree/main/JWT%20Authentication)
Custom code for JWT-based authentication. User creating connection reference will need to set the authentication URL in the variable authURL.

### [OAuth 2.0 (non-standard)](https://github.com/troystaylor/Connector-Code/tree/main/OAuth%202.0%20(non-standard))
Custom code examples for handling non-standard OAuth 2.0 authentication flows. Includes implementations for Precisely API (client credentials with basic auth) and MailPlus. Useful for APIs that don't follow standard OAuth patterns.

### [OAuth 2.0 PKCE](https://github.com/troystaylor/Connector-Code/tree/main/OAuth%202.0%20PKCE)
Custom code needed to fix the Airtable connector when the service moved from API key to OAuth 2.0 PKCE authentication.

### [OKTA](https://github.com/troystaylor/Connector-Code/tree/main/OKTA)
Custom code for OKTA OAuth 2.0 client credentials authentication. Handles the token exchange from Basic Auth to Bearer token for OKTA API calls. Configure your OKTA domain and required scopes in the script variables.

### [Set ConnectionParameter to Body Key](https://github.com/troystaylor/Connector-Code/tree/main/Set%20ConnectionParameter%20to%20Body%20Key)
Workaround for Set Property Policy Template issue when using connection parameters to set POST request body keys. Uses Set Query String Parameter policy then moves the parameter to the request body via custom code.

### [Copilot Instructions](https://github.com/troystaylor/Connector-Code/tree/main/.github)
This folder can be added to a .github folder in your VS Code workspace to help validate Power Platform connector artifacts.

### [Copilot Retrieval](https://github.com/troystaylor/Connector-Code/tree/main/Copilot%20Retrieval)
Microsoft 365 Copilot Retrieval API connector with Model Context Protocol (MCP) server implementation. Provides tools for retrieving relevant text extracts from SharePoint, OneDrive, and Copilot connectors for grounding AI applications. Includes 4 MCP tools: retrieve_from_sharepoint, retrieve_from_onedrive, retrieve_from_copilot_connectors, and retrieve_multi_source.

### [Handle Null Values](https://github.com/troystaylor/Connector-Code/blob/main/HandleNullValues.csx)
This script is designed to work with APIs that return null values instead of empty values. Power Platform connectors currently are defined as Swagger, which does not allow null or multiple values. Contains an optional method InferTypeFromPropertyName to define custom field types based on property/field/key name.

### [Handle Array Response with Mixed Types](https://github.com/troystaylor/Connector-Code/blob/main/ArrayResponseMixedTypes.csx)
This script is designed to be used with APIs that return an OpenAPI 3.x array response of mixed types. It was designed for the World Bank API.
