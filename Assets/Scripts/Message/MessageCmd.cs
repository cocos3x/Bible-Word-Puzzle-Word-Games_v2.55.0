using UnityEngine;

namespace Message
{
    public enum MessageCmd
    {
        // Fields
        OnUpdate = 0
        ,OnLevelPass = 1
        ,OnLevelPassVideoReward = 2
        ,OnSectionPass = 3
        ,OnLevelPassReward = 4
        ,OnRequestWordDataCallBack = 5
        ,ShowBiblePanel = 6
        ,ShowBibleBookPanel = 7
        ,CloseBible = 8
        ,ShowBibleStartButton = 9
        ,OpenNowBiblePanel = 10
        ,ShowBibleCollectComplete = 11
        ,OnShowCompletedEnd = 12
        ,OnOpenChestCallback = 13
        ,OnBibleContentOpenCallback = 14
        ,OnBibleContentShowTopCallback = 15
        ,OnBibleContentShowBottomCallback = 16
        ,OnBibleContentHideCallback = 17
        ,OnBibleContentPageCallback = 18
        ,OnBibleContentPageUpdate = 19
        ,OnCollectAllVerseFromSection = 20
        ,OnShowBibleContentBottom = 21
        ,SetBonusGuideWordsState = 22
        ,OnGetCoinIconPosition = 23
        ,OnGetCoinIconPositionFixed = 24
        ,OnShopButtonCoinPosition = 25
        ,DailyCheckDoveVacancy = 26
        ,DailyCreateDoveFromVacancy = 27
        ,DailyFlyDoveReachVacancy = 28
        ,SetSelectDoveLetter = 29
        ,ShuffleLetterBlock = 30
        ,ShowHintWordFromDove = 31
        ,SetGuideMaskBgState = 32
        ,CreateBonusGuideMasks = 33
        ,OnBackHomeClear = 34
        ,OnPrepareLeaveGameScene = 35
        ,OnChangeLetterGuide = 36
        ,OnLoadingProgress = 37
        ,OnHideLoading = 38
        ,OnShowLoadingAni = 39
        ,OnOpenHome = 40
        ,OnOpenHomeCallback = 41
        ,OnHomeHideToGameCallBack = 42
        ,OnUpdateLotteryState = 43
        ,OnBeginGame = 44
        ,OnRestartNextGame = 45
        ,OnGameComplete = 46
        ,OnPlayGameCompleteAni = 47
        ,OnFinishMission = 48
        ,OnUpdateTreasureIcon = 49
        ,OnDoChapterWin = 50
        ,OnRefreshBottleProgress = 51
        ,OnShowSideButton = 52
        ,OnShowSideButtonGift = 53
        ,OnHideSideButton = 54
        ,OnAddExtraWord = 55
        ,OnClearGameView = 56
        ,OnGameHintClick = 57
        ,OnGameShuffleClick = 58
        ,OnSetBottomButtonState = 59
        ,OnChangeBottomBtnCanvasSorting = 60
        ,OnGameHideToHomeCallBack = 61
        ,OnGameHideToHomeBegin = 62
        ,OnPlayHideBlockAni = 63
        ,OnShowFromHomeCallBackChrysalis = 64
        ,OnGameShowFromHomeCallBack = 65
        ,OnSetGameBibleIconState = 66
        ,OnChangeDictionaryButtonState = 67
        ,OnGiftBoxDeathCallback = 68
        ,OnGiftBoxGiveFreeHint = 69
        ,OnLogEventFailCount = 70
        ,OnUpdateHintCount = 71
        ,OnUpdateFireworkCount = 72
        ,OnSetHintFree = 73
        ,OnShowBanner = 74
        ,OnHideBanner = 75
        ,OnSelectQuizOption = 76
        ,OnSelectRightQuizOption = 77
        ,OnCoinChangeNotify = 78
        ,OnCheckShopSale = 79
        ,OnShowResultBibleContent = 80
        ,OnCollectResultBible = 81
        ,OnNextLevel = 82
        ,OnLevelPassUpdateData = 83
        ,OnPlayCollectBookEffect = 84
        ,OnCheckPiggyBank = 85
        ,OnCheckChrysalisProgress = 86
        ,OnProgressIncrease = 87
        ,OnSaveDailyGiftBoxProgress = 88
        ,OnShowDailyLotteryVideoButton = 89
        ,OnGiftRewardVideoCallback = 90
        ,OnBeginDailyPrayer = 91
        ,OnClearDailyPrayerView = 92
        ,OnSelectSignDay = 93
        ,OnPlayCollectStarsAnimator = 94
        ,OnPlayCollectStarsAnimatorEnd = 95
        ,OnDailySignShowCallback = 96
        ,OnCloseDailySign = 97
        ,OnLoadedAdCallback = 98
        ,OnShowFireworks = 99
        ,OnFireworkArrive = 100
        ,OnFireworkLetterFly = 101
        ,OnPlayFireworkAnim = 102
        ,OnFireworkAnimFinish = 103
        ,OnShowMoreOffers = 104
        ,OnPurchaseSuccess = 105
        ,OnPurchaseFailed = 106
        ,OnCollectChrysalisFly = 107
        ,OnCollectChrysalis = 108
        ,OnUpdateChrysalisIconPos = 109
        ,OnUpdateChrysalisState = 110
        ,OnCollectButterFly = 111
        
    
    }

}