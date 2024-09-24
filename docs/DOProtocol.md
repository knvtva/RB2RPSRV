## [NEX-Protocols](https://github.com/kinnay/NintendoClients/wiki/NEX-Protocols) > DOProtocol (Unknown ID)

| Method ID | Method Name |
| --- | --- |
| 1 | [MigrateObject](#1-migrateobject) |
| 2 | [CreateDuplica](#2-createduplica) |
| 3 | [CreateAndPromoteDuplica](#3-createandpromoteduplica) |

# (1) MigrateObject

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint16 | uiCallID |  |
| dohandle | hSender |  |
| dohandle | hObject |  |
| dohandle | hNewMaster |  |
| Uint8 | byNewMasterVersion |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;dohandle&#x3E; | lstDupSet |  |

## Response
This method does not return anything

# (2) CreateDuplica

## Request
| Type | Name | Description |
| --- | --- | --- |
| dohandle | hObject |  |
| dohandle | hMaster |  |
| Uint8 | byMasterVersion |  |
| [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) | bufObjectContent |  |

## Response
This method does not return anything

# (3) CreateAndPromoteDuplica

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint16 | uiCallID |  |
| dohandle | hObject |  |
| dohandle | hMaster |  |
| Uint8 | byMasterVersion |  |
| [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) | bufObjectContent |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;dohandle&#x3E; | lstDupSet |  |

## Response
This method does not return anything