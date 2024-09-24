## [NEX-Protocols](https://github.com/kinnay/NintendoClients/wiki/NEX-Protocols) > RBBotb (Unknown ID)

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
| 36 | [GetBattleById](#36-getbattlebyid) |
| 37 | [GetOpenBattles](#37-getopenbattles) |
| 38 | [GetOpenBattleResultsByBand](#38-getopenbattleresultsbyband) |
| 39 | [GetClosedBattleResultsByBand](#39-getclosedbattleresultsbyband) |
| 40 | [GetBattlesByBand](#40-getbattlesbyband) |
| 41 | [GetCitiesWithOpenBattles](#41-getcitieswithopenbattles) |
| 42 | [PlayBattle](#42-playbattle) |
| 43 | [GetBattleResultsByBand](#43-getbattleresultsbyband) |
| 44 | [GetBattleResultsByRankRange](#44-getbattleresultsbyrankrange) |
| 45 | [GetBattleResultsByFriends](#45-getbattleresultsbyfriends) |
| 46 | [RecordBattleScore](#46-recordbattlescore) |
| 47 | [GetDailyNews](#47-getdailynews) |
| 48 | [GetDailyNewsCookies](#48-getdailynewscookies) |
| 49 | [GetBattleNews](#49-getbattlenews) |
| 50 | [UnitTestBotb](#50-unittestbotb) |
| 51 | [UpdateFriendList](#51-updatefriendlist) |

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

# (36) GetBattleById

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | localeName |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBBotbBattleDetails](#rbbotbbattledetails) | results |  |

# (37) GetOpenBattles

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | showIn |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | localeName |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbOpenBattleInfo](#rbbotbopenbattleinfo)&#x3E; | results |  |

# (38) GetOpenBattleResultsByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [RBGuid](#rbguid) | bandGuid |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBBotbBattleResultsByBandInfo](#rbbotbbattleresultsbybandinfo) | results |  |

# (39) GetClosedBattleResultsByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [RBGuid](#rbguid) | bandGuid |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBBotbBattleResultsByBandInfo](#rbbotbbattleresultsbybandinfo) | results |  |

# (40) GetBattlesByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | howFarBack |  |
| Bool | byQuantity |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | localeName |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbBattleParticipatedIn](#rbbotbbattleparticipatedin)&#x3E; | results |  |

# (41) GetCitiesWithOpenBattles

## Request
This method does not take any parameters

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbCityWithBattle](#rbbotbcitywithbattle)&#x3E; | results |  |

# (42) PlayBattle

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [RBGuid](#rbguid) | bandGuid |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBBotbPlayBattleResponse](#rbbotbplaybattleresponse) | results |  |

# (43) GetBattleResultsByBand

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | bandsAround |  |
| Uint32 | offset |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbBattleRow](#rbbotbbattlerow)&#x3E; | results |  |

# (44) GetBattleResultsByRankRange

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| Uint32 | topRank |  |
| Uint32 | bottomRank |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbBattleRow](#rbbotbbattlerow)&#x3E; | results |  |

# (45) GetBattleResultsByFriends

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [RBGuid](#rbguid) | bandGuid |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbBattleRow](#rbbotbbattlerow)&#x3E; | results |  |

# (46) RecordBattleScore

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | battleID |  |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | score |  |
| Uint32 | stars |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [RBBotbRecordBattleResponse](#rbbotbrecordbattleresponse) | results |  |

# (47) GetDailyNews

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | localeName |  |
| [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) | lastTime |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | lastCookies |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) | curTime |  |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | newCookies |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbNewsItem](#rbbotbnewsitem)&#x3E; | results |  |

# (48) GetDailyNewsCookies

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | newCookies |  |

# (49) GetBattleNews

## Request
| Type | Name | Description |
| --- | --- | --- |
| [RBGuid](#rbguid) | bandGuid |  |
| Uint32 | battleID |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;Uint32&#x3E; | principalIDs |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbNewsItem](#rbbotbnewsitem)&#x3E; | results |  |

# (50) UnitTestBotb

## Request
This method does not take any parameters

## Response
| Type | Name | Description |
| --- | --- | --- |
| [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) | result |  |

# (51) UpdateFriendList

## Request
| Type | Name | Description |
| --- | --- | --- |
| Uint32 | principalID |  |
| [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBPlatformGuid](#rbplatformguid)&#x3E; | friends |  |

## Response
| Type | Name | Description |
| --- | --- | --- |
| Bool | result |  |

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

## RBBotbBattleSongInfo ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mShortName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mFullName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mArtist | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |

## RBBotbBattleDetails ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mBattleID | Uint32 |
| mShortName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mTitle | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mDescription | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mArtFilename | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mVenueName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mDifficulty | Uint32 |
| mShowIn | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mStartTime | [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) |
| mEndTime | [DateTime](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#datetime) |
| mTimeLeftInSeconds | Uint32 |
| mWinMetric | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mEntryConditions | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mPerformanceModifiers | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mSetList | [List](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#list)&#x3C;[RBBotbBattleSongInfo](#rbbotbbattlesonginfo)&#x3E; |
| mPrize | Uint32 |
| mSecondsUntilStart | Sint32 |

## RBBotbOpenBattleInfo ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mBattleID | Uint32 |
| mShortName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mTitle | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mAlreadyPlayed | Bool |
| mShowIn | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mVenueName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mArtFilename | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |

## RBBotbBattleResultsByBandInfo ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mCarrotInfo | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mOverallRank | Uint32 |
| mTotalRanked | Uint32 |

## RBBotbBattleParticipatedIn ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mBattleID | Uint32 |
| mBattleName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mBandRank | Uint32 |
| mBattleOpen | Bool |
| mArtFilename | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mNumPostedScores | Uint32 |

## RBBotbCityWithBattle ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mVenueName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |

## RBBotbPlayBattleResponse ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mCanPlay | Bool |
| mRivalBandName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mRivalBandScore | Uint32 |
| mRivalBandStars | Uint32 |
| mRivalBandLeader | [RBPlatformGuid](#rbplatformguid) |
| mPatch | [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) |

## RBBotbBattleRow ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mName | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mScore | Uint32 |
| mStars | Uint32 |
| mOverallRank | Uint32 |
| mBandGuid | [RBGuid](#rbguid) |
| mPatch | [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) |

## RBBotbRecordBattleResponse ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mPerformanceInfo | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mApproxOverallRank | Uint32 |
| mCarrotInfo | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mPatch | [Buffer](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#buffer) |
| mNewsCookies | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |

## RBBotbNewsItem ([Structure](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#structure))
| Name | Type |
| --- | --- |
| mNewsItem | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |
| mArtFilename | [String](https://github.com/kinnay/NintendoClients/wiki/NEX-Common-Types#string) |