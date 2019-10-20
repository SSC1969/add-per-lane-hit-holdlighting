/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) Swan & The Quaver Team <support@quavergame.com>.
*/

using Microsoft.Xna.Framework.Graphics;
using Wobble.Managers;

namespace Quaver.Shared.Assets
{
    public static class UserInterface
    {
        public static Texture2D BlankBox => TextureManager.Load($"Quaver.Resources/Textures/UI/blank-box.png");
        public static Texture2D UnknownAvatar => TextureManager.Load($"Quaver.Resources/Textures/UI/unknown-avatar.png");
        public static Texture2D YouAvatar => TextureManager.Load($"Quaver.Resources/Textures/UI/you-avatar.png");
        public static Texture2D MenuBackground => TextureManager.Load($"Quaver.Resources/Textures/UI/Menu/menu-background.jpg");
        public static Texture2D NotificationError => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-error.png");
        public static Texture2D NotificationWarning => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-warning.png");
        public static Texture2D NotificationInfo => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-info.png");
        public static Texture2D NotificationSuccess => TextureManager.Load("Quaver.Resources/Textures/UI/Notifications/notif-success.png");
        public static Texture2D SelectSearchBackground => TextureManager.Load("Quaver.Resources/Textures/UI/select-search-background.png");
        public static Texture2D ThumbnailSinglePlayer => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-single-player.jpg");
        public static Texture2D ThumbnailCompetitive => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-competitive.jpg");
        public static Texture2D ThumbnailCustomGames => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-custom-games.jpg");
        public static Texture2D ThumbnailEditor => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/thumbnail-editor.jpg");
        public static Texture2D LoadingWheel => TextureManager.Load("Quaver.Resources/Textures/UI/loading-wheel.png");
        public static Texture2D StatusRanked => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-ranked.png");
        public static Texture2D StatusUnranked => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-unranked.png");
        public static Texture2D StatusNotSubmitted => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-not-submitted.png");
        public static Texture2D StatusDanCourse => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-dancourse.png");
        public static Texture2D StatusOtherGameOsu => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-other-game-osu.png");
        public static Texture2D StatusVarious => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-various.png");
        public static Texture2D StatusNone => TextureManager.Load("Quaver.Resources/Textures/UI/RankedStatus/status-none.png");
        public static Texture2D SelectButtonBackground => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/select-button-background.png");
        public static Texture2D HorizontalSelectorLeft => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/horizontal-selector-left.png");
        public static Texture2D HorizontalSelectorRight => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/horizontal-selector-right.png");
        public static Texture2D QuaverLogoFull => TextureManager.Load("Quaver.Resources/Textures/UI/quaver-logo-full.png");
        public static Texture2D MenuBackgroundBlurred => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-blurred.jpg");
        public static Texture2D QuaverLogoStylish => TextureManager.Load("Quaver.Resources/Textures/UI/quaver-logo-stylish.png");
        public static Texture2D EditorToolSelect => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/select.png");
        public static Texture2D EditorLayerPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/layer-panel.png");
        public static Texture2D EditorEditLayerPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/edit-layer-panel.png");
        public static Texture2D EditorMetadataPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/metadata-panel.png");
        public static Texture2D EditorHitsoundsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/hitsounds-panel.png");
        public static Texture2D EditorCompositionToolsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/composition-tools-panel.png");
        public static Texture2D EditorDetailsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Editor/details-panel.png");
        public static Texture2D MenuBackgroundRaw => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-raw.jpg");
        public static Texture2D MenuBackgroundClear => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-clear.jpg");
        public static Texture2D LobbyCreateGame => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/create-game.png");
        public static Texture2D TeamBannerRed => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/team-banner-red.png");
        public static Texture2D TeamBannerBlue => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/team-banner-blue.png");
        public static Texture2D BattleRoyaleGradient => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/battle-royale-gradient.png");
        public static Texture2D BattleRoyalePanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/battle-royale-panel.png");
        public static Texture2D WaitingPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/waiting-panel.png");
        public static Texture2D WinsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/wins-panel.png");
        public static Texture2D ScoreboardBlueMirrored => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/scoreboard-blue-mirrored.png");
        public static Texture2D UserPanelFFA => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-ffa.png");
        public static Texture2D UserPanelRed => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-red.png");
        public static Texture2D UserPanelBlue => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-blue.png");
        public static Texture2D UserPanelReferee => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/user-panel-referee.png");
        public static Texture2D MapPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/map-panel.png");
        public static Texture2D FeedPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/feed-panel.png");
        public static Texture2D MultiplayerSettingaPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/settings-panel.png");
        public static Texture2D PlayerOptionsPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Multiplayer/player-options-panel.png");
        public static Texture2D ResultHeaderPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-header-panel.png");
        public static Texture2D ResultScorePanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-score-panel.png");
        public static Texture2D ResultMultiplayerPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-multiplayer-panel.png");
        public static Texture2D ResultMultiplayerTeamPanel => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-multiplayer-team-panel.png");
        public static Texture2D ResultRedTeam => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-red-team.png");
        public static Texture2D ResultBlueTeam => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-blue-team.png");
        public static Texture2D ResultNoTeam => TextureManager.Load("Quaver.Resources/Textures/UI/Results/result-no-team.png");
        public static Texture2D JukeboxPanel => TextureManager.Load("Quaver.Resources/Textures/UI/MainMenu/jukebox-panel.png");
        public static Texture2D PlayercardBackground => TextureManager.Load("Quaver.Resources/Textures/UI/Playercard/playercard-background.png");
        public static Texture2D MenuBackgroundNormal => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-background-normal.jpg");
        public static Texture2D PlayercardCoverDefault => TextureManager.Load("Quaver.Resources/Textures/UI/Playercard/playercard-cover-default.png");
        public static Texture2D DownloadSearchPanel => TextureManager.Load("Quaver.Resources/Textures/UI/download-search.png");
        public static Texture2D DownloadItem => TextureManager.Load("Quaver.Resources/Textures/UI/download-item.png");
        public static Texture2D DownloadMapsetInfo => TextureManager.Load("Quaver.Resources/Textures/UI/mapset-info.png");
        public static Texture2D SelectedMapset => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/selected-mapset.png");
        public static Texture2D DeselectedMapset => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/deselected-mapset.png");
        public static Texture2D SelectSearchPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/search-panel.png");
        public static Texture2D LeaderboardScore => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/leaderboard-score.png");
        public static Texture2D LeaderboardPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/leaderboard-panel.png");
        public static Texture2D Logo => TextureManager.Load("Quaver.Resources/Textures/UI/logo.png");
        public static Texture2D SessionTimeBackground => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/session-time-background.png");
        public static Texture2D MenuBorderBackground => TextureManager.Load("Quaver.Resources/Textures/UI/Menu/menu-border-background.png");
        public static Texture2D FilterPanelGradient => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/filter-panel-gradient.png");
        public static Texture2D DropdownClosed => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/dropdown-closed.png");
        public static Texture2D DropdownOpen => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/dropdown-open.png");
        public static Texture2D DropdownBottom => TextureManager.Load("Quaver.Resources/Textures/UI/Elements/dropdown-bottom.png");
        public static Texture2D SearchBox => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/search-box.png");
        public static Texture2D Keys4Panel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/keys4.png");
        public static Texture2D Keys7Panel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/keys7.png");
        public static Texture2D KeysNonePanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/keys-none.png");
        public static Texture2D BothModesPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/both-modes-panel.png");
        public static Texture2D ModePanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/mode-panel.png");
        public static Texture2D EditPlayButton => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/edit-play-button.png");
        public static Texture2D StatusPanel => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/status-panel.png");
        public static Texture2D DefaultBanner => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/default-banner.png");
        public static Texture2D DifficultyBarBackground => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/difficultybar-bg.png");
        public static Texture2D DifficultyBarColor => TextureManager.Load("Quaver.Resources/Textures/UI/SongSelect/difficultybar-colour.png");
        public static Texture2D LeaderboardScoresPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/leaderboard-scores-panel.png");
        public static Texture2D PersonalBestScorePanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/personal-best-score-panel.png");
        public static Texture2D WarningRed => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/warning-red.png");
        public static Texture2D Clock => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/clock.png");
        public static Texture2D Triangles => TextureManager.Load(@"Quaver.Resources/Textures/UI/triangles.png");
        public static Texture2D ModifierSelectorBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/modifier-selector-bg.png");
        public static Texture2D Off => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/off.png");
        public static Texture2D On => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/on.png");
        public static Texture2D ResetMods => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/reset-mods.png");
        public static Texture2D ClosePanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/SongSelect/close-panel.png");
        public static Texture2D CreateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/create-button.png");
        public static Texture2D CancelButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/cancel-button.png");
        public static Texture2D UpdateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/update-button.png");
        public static Texture2D YesNoPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/yes-no-panel.png");
        public static Texture2D CustomizeButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/customize-button.png");
        public static Texture2D JudgementWindowPanel => TextureManager.Load(@"Quaver.Resources/Textures/UI/judgement-window-panel.png");
        public static Texture2D JudgementWindowHeaderBanner => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/header-banner.png");
        public static Texture2D JudgementWindowCloseButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/close-button.png");
        public static Texture2D JudgementWindowCreateButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/create-button.png");
        public static Texture2D JudgementWindowDeleteButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/delete-button.png");
        public static Texture2D JudgementWindowEditNameButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/edit-name-button.png");
        public static Texture2D JudgementWindowResetButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/JudgementWindows/reset-button.png");
        public static Texture2D SliderProgressBall => TextureManager.Load(@"Quaver.Resources/Textures/UI/slider-progress-ball.png");
        public static Texture2D JukeboxPlayButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-play-button.png");
        public static Texture2D JukeboxPauseButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-pause-button.png");
        public static Texture2D JukeboxHamburgerIcon => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-hamburger-icon.png");
        public static Texture2D JukeboxBackwardButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-backward-button.png");
        public static Texture2D JukeboxInfoBackground => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-info-bg.png");
        public static Texture2D JukeboxInfoButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-info-button.png");
        public static Texture2D JukeboxFade => TextureManager.Load(@"Quaver.Resources/Textures/UI/Jukebox/jukebox-fade.png");
        public static Texture2D HostCrown => TextureManager.Load(@"Quaver.Resources/Textures/UI/host-crown.png");
        public static Texture2D LoginButton => TextureManager.Load(@"Quaver.Resources/Textures/UI/login-button.png");
    }
}
