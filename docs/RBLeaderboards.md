## [NEX-Protocols](https://github.com/kinnay/NintendoClients/wiki/NEX-Protocols) > RBLeaderboards (Unknown ID)

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
| 13 | [RecordSoloScore](#13-recordsoloscore) |
| 14 | [RecordSoloCareerScore](#14-recordsolocareerscore) |
| 15 | [RecordBandScore](#15-recordbandscore) |
| 16 | [RecordBandCareerScore](#16-recordbandcareerscore) |
| 17 | [RecordBandFans](#17-recordbandfans) |
| 18 | [GetSoloHighScoresByPlayer](#18-getsolohighscoresbyplayer) |
| 19 | [GetSoloHighScoresByRankRange](#19-getsolohighscoresbyrankrange) |
| 20 | [GetSoloHighScoresByFriends](#20-getsolohighscoresbyfriends) |
| 21 | [GetSoloCareerHighScoresByPlayer](#21-getsolocareerhighscoresbyplayer) |
| 22 | [GetSoloCareerHighScoresByRankRange](#22-getsolocareerhighscoresbyrankrange) |
| 23 | [GetSoloCareerHighScoresByFriends](#23-getsolocareerhighscoresbyfriends) |
| 24 | [GetBandHighScoresByBand](#24-getbandhighscoresbyband) |
| 25 | [GetBandHighScoresByRankRange](#25-getbandhighscoresbyrankrange) |
| 26 | [GetBandHighScoresByFriends](#26-getbandhighscoresbyfriends) |
| 27 | [GetBandCareerHighScoresByBand](#27-getbandcareerhighscoresbyband) |
| 28 | [GetBandCareerHighScoresByRankRange](#28-getbandcareerhighscoresbyrankrange) |
| 29 | [GetBandCareerHighScoresByFriends](#29-getbandcareerhighscoresbyfriends) |
| 30 | [GetBandFansByBand](#30-getbandfansbyband) |
| 31 | [GetBandFansByRankRange](#31-getbandfansbyrankrange) |
| 32 | [GetBandFansByFriends](#32-getbandfansbyfriends) |
| 33 | [GetSkillByPlayer](#33-getskillbyplayer) |
| 34 | [GetSkillByRankRange](#34-getskillbyrankrange) |
| 35 | [GetSkillByFriends](#35-getskillbyfriends) |

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

# (13) RecordSoloScore

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| Sint8 | roleID |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |
| Uint32 | songScore |  |
| Uint32 | careerScore |  |
| Sint8 | diffID |  |

## Response
This method does not return anything

# (14) RecordSoloCareerScore

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| Sint8 | roleID |  |
| Uint32 | score |  |

## Response
This method does not return anything

# (15) RecordBandScore

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |
| Uint32 | songScore |  |
| Uint32 | careerScore |  |
| Uint32 | fans |  |

## Response
This method does not return anything

# (16) RecordBandCareerScore

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | score |  |

## Response
This method does not return anything

# (17) RecordBandFans

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | fans |  |

## Response
This method does not return anything

# (18) GetSoloHighScoresByPlayer

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| Sint8 | roleID |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |
| Sint16 | playersAround |  |
| Sint16 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSoloResults](#rbsoloresults)&#x3E; | results |  |

# (19) GetSoloHighScoresByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | roleID |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSoloResults](#rbsoloresults)&#x3E; | results |  |

# (20) GetSoloHighScoresByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |
| Sint8 | roleID |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSoloResults](#rbsoloresults)&#x3E; | results |  |

# (21) GetSoloCareerHighScoresByPlayer

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| Sint8 | roleID |  |
| Sint16 | playersAround |  |
| Sint16 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSoloResults](#rbsoloresults)&#x3E; | results |  |

# (22) GetSoloCareerHighScoresByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | roleID |  |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSoloResults](#rbsoloresults)&#x3E; | results |  |

# (23) GetSoloCareerHighScoresByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |
| Sint8 | roleID |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSoloResults](#rbsoloresults)&#x3E; | results |  |

# (24) GetBandHighScoresByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |
| Sint16 | playersAround |  |
| Sint16 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (25) GetBandHighScoresByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (26) GetBandHighScoresByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | songName |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (27) GetBandCareerHighScoresByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Sint16 | playersAround |  |
| Sint16 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (28) GetBandCareerHighScoresByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (29) GetBandCareerHighScoresByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (30) GetBandFansByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Sint16 | playersAround |  |
| Sint16 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (31) GetBandFansByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (32) GetBandFansByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBandResults](#rbbandresults)&#x3E; | results |  |

# (33) GetSkillByPlayer

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| Sint8 | modeID |  |
| Sint8 | roleID |  |
| Sint8 | diffID |  |
| Sint16 | playersAround |  |
| Sint16 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSkillResults](#rbskillresults)&#x3E; | results |  |

# (34) GetSkillByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| Sint8 | modeID |  |
| Sint8 | roleID |  |
| Sint8 | diffID |  |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSkillResults](#rbskillresults)&#x3E; | results |  |

# (35) GetSkillByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |
| Sint8 | modeID |  |
| Sint8 | roleID |  |
| Sint8 | diffID |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBSkillResults](#rbskillresults)&#x3E; | results |  |

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

## RBSoloResults ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mPlayerName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mGuid | Sint64 |
| mPrincipalID | Uint32 |
| mDiffID | Sint8 |
| mRank | Uint32 |
| mScore | Uint32 |

## RBBandResults ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mBandName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mGuid | [RBGuid](#rbguid) |
| mBandID | Uint32 |
| mRank | Uint32 |
| mScore | Uint32 |

## RBSkillResults ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mPlayerName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mGuid | Sint64 |
| mPrincipalID | Uint32 |
| mRank | Uint32 |
| mSkill | Uint32 |