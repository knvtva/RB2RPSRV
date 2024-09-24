## [NEX-Protocols](https://github.com/kinnay/NintendoClients/wiki/NEX-Protocols) > RBConfig (Unknown ID)

| Method ID | Method Name |
| --- | --- |
| 1 | [UpdatePlayer](#1-updateplayer) |
| 2 | [UpdateCharacter](#2-updatecharacter) |
| 3 | [UpdateCharSecData](#3-updatecharsecdata) |
| 4 | [UpdateBand](#4-updateband) |
| 5 | [IsLegalCharacterName](#5-islegalcharactername) |
| 6 | [IsLegalBandName](#6-islegalbandname) |
| 7 | [IsLegalBandMotto](#7-islegalbandmotto) |
| 8 | [GetBand](#8-getband) |
| 9 | [GetChar](#9-getchar) |
| 10 | [UpdateBandSecData](#10-updatebandsecdata) |
| 11 | [GetPresenceInfo](#11-getpresenceinfo) |
| 12 | [GetConfig](#12-getconfig) |

# (1) UpdatePlayer

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| Uint32 | webPasscode |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | locale |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | motd |  |

# (2) UpdateCharacter

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | charGuid |  |
| [RBCharacter](#rbcharacter) | charData |  |
| Sint8 | checkFlags |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | returnCode |  |
| Uint32 | charID |  |

# (3) UpdateCharSecData

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | charGuid |  |
| Uint32 | cash |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | charID |  |

# (4) UpdateBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| [RBBand](#rbband) | bandData |  |
| Sint8 | checkFlags |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBGuid](#rbguid)&#x3E; | members |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandTopScore](#rbbandtopscore)&#x3E; | topScores |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | returnCode |  |
| Uint32 | bandID |  |

# (5) IsLegalCharacterName

## Request
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | charName |  |
| Sint8 | checkFlags |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | returnCode |  |

# (6) IsLegalBandName

## Request
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | bandName |  |
| Sint8 | checkFlags |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | returnCode |  |

# (7) IsLegalBandMotto

## Request
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | motto |  |
| Sint8 | checkFlags |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | returnCode |  |

# (8) GetBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBBand](#rbband) | bandData |  |
| [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) | createDate |  |
| Uint32 | fans |  |
| Uint32 | careerScore |  |
| [RBPlatformGuid](#rbplatformguid) | ownerInfo |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandMember](#rbbandmember)&#x3E; | members |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandTopScore](#rbbandtopscore)&#x3E; | topScores |  |

# (9) GetChar

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | charGuid |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBCharacter](#rbcharacter) | charData |  |
| [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) | createDate |  |
| [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) | lastUpdate |  |

# (10) UpdateBandSecData

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | stars |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | bandID |  |

# (11) GetPresenceInfo

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | memlist |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPresenceInfo](#rbpresenceinfo)&#x3E; | onlinelist |  |

# (12) GetConfig

## Request
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | inDTA |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | sandboxVersion |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | outDTA |  |

# Types

## RBGuid ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mGuid0 | Uint32 |
| mGuid1 | Uint32 |
| mGuid2 | Uint32 |
| mGuid3 | Uint32 |

## RBPlatformGuid ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mGuid | Sint64 |

## RBPresenceInfo ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mPlatformGuid | [RBPlatformGuid](#rbplatformguid) |
| mOnline | Bool |

## RBCharacter ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mPrincipalID | Uint32 |
| mName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mHometown | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mOutfit | [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) |
| mCash | Uint32 |

## RBBand ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mLeaderID | Uint32 |
| mName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mMotto | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mHometown | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mPatch | [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) |
| mStars | Uint32 |
| mStarRating | Uint32 |
| mDiffRating | Uint32 |
| mTotalScore | Uint32 |

## RBBandMember ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mGuid | [RBGuid](#rbguid) |
| mPlatformGuid | [RBPlatformGuid](#rbplatformguid) |

## RBBandTopScore ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mShortName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mFullName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mScore | Uint32 |
| mStars | Uint32 |