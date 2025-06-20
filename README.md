# Connector Code
This repo contains script files that will work with Power Platform connectors.

### [Handle Null Values](https://github.com/troystaylor/Connector-Code/blob/main/HandleNullValues.csx)
This script is designed to work with APIs that return null values instead of empty values. Power Platform connectors currently are defined as Swagger, which does not allow null or multiple values. Contains an optional method InferTypeFromPropertyName to define custom field types based on property/field/key name.

### [Handle Array Response with Mixed Types](https://github.com/troystaylor/Connector-Code/blob/main/ArrayResponseMixedTypes.csx)
This script is designed to be used with APIs that return an OpenAPI 3.x array response of mixed types. It was designed for the World Bank API.
