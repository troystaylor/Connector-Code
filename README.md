# Connector Code
This repo contains script files that will work with Power Platform connectors.

### [Bearer Token Authorization](https://github.com/troystaylor/Connector-Code/tree/main/Bearer%20Token%20Authorization)
This custom code works with the API Key security method when the parameter name is set to Authorization. It removes the need to ask the user to enter "Bearer " before the token value.

### [Copilot Instructions](https://github.com/troystaylor/Connector-Code/tree/main/.github)
This folder can be added to a .github folder in your VS Code workspace to help validate Power Platform connector artifacts.

### [Copilot Retrieval](https://github.com/troystaylor/Connector-Code/tree/main/Copilot%20Retrieval)
Microsoft 365 Copilot Retrieval API connector with Model Context Protocol (MCP) server implementation. Provides tools for retrieving relevant text extracts from SharePoint, OneDrive, and Copilot connectors for grounding AI applications. Includes 4 MCP tools: retrieve_from_sharepoint, retrieve_from_onedrive, retrieve_from_copilot_connectors, and retrieve_multi_source.

### [Handle Null Values](https://github.com/troystaylor/Connector-Code/blob/main/HandleNullValues.csx)
This script is designed to work with APIs that return null values instead of empty values. Power Platform connectors currently are defined as Swagger, which does not allow null or multiple values. Contains an optional method InferTypeFromPropertyName to define custom field types based on property/field/key name.

### [Handle Array Response with Mixed Types](https://github.com/troystaylor/Connector-Code/blob/main/ArrayResponseMixedTypes.csx)
This script is designed to be used with APIs that return an OpenAPI 3.x array response of mixed types. It was designed for the World Bank API.
