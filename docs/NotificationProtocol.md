## [NEX-Protocols](https://github.com/kinnay/NintendoClients/wiki/NEX-Protocols) > NotificationProtocol (Unknown ID)

| Method ID | Method Name |
| --- | --- |
| 1 | [ProcessNotificationEvent](#1-processnotificationevent) |

# (1) ProcessNotificationEvent

## Request
| Type | Name | Description |
| --- | --- | --- |
| [NotificationEvent](#notificationevent) | oEvent |  |

## Response
This method does not return anything

# Types

## MessageRecipient ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| m_idRecipient | Uint32 |
| m_uiRecipientType | Uint32 |

## NotificationEvent ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| m_pidSource | Uint32 |
| m_uiType | Uint32 |
| m_uiParam1 | Uint32 |
| m_uiParam2 | Uint32 |
| m_strParam | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |