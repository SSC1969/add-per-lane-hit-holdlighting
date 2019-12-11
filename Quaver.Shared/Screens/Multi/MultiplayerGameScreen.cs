using System;
using System.Collections.Generic;
using Quaver.API.Enums;
using Quaver.Server.Common.Enums;
using Quaver.Server.Common.Objects;
using Quaver.Server.Common.Objects.Multiplayer;
using Quaver.Shared.Online;
using Wobble.Bindables;

namespace Quaver.Shared.Screens.Multi
{
    public sealed class MultiplayerGameScreen : QuaverScreen
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public override QuaverScreenType Type { get; } = QuaverScreenType.Multiplayer;

        /// <summary>
        ///     The current multiplayer game
        /// </summary>
        public Bindable<MultiplayerGame> Game { get; private set; }

        /// <summary>
        /// </summary>
        public MultiplayerGameScreen()
        {
            CreateGameBindable();
            ScreenExiting += (sender, args) => OnlineManager.LeaveGame();
            View = new MultiplayerGameScreenView(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public override void Destroy()
        {
            Game?.Dispose();
            base.Destroy();
        }

        /// <summary>
        ///     Creates <see cref="Game"/>
        /// </summary>
        private void CreateGameBindable()
        {
            var game = OnlineManager.CurrentGame ?? GetTestGame();
            Game = new Bindable<MultiplayerGame>(game) {Value = game};
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override UserClientStatus GetClientStatus() => new UserClientStatus(ClientStatus.Multiplayer, -1, "-1", 1, "", 0);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private MultiplayerGame GetTestGame()
        {
            return new MultiplayerGame
            {
                Id = "abc123",
                GameId = 999,
                Name = "Example Game",
                Type = MultiplayerGameType.Friendly,
                Ruleset = MultiplayerGameRuleset.Team,
                GameMode = (byte) GameMode.Keys4,
                PlayerIds = new List<int>(),
                MaxPlayers = 16,
                MapMd5 = "None",
                AlternativeMd5 = "None",
                MapId = -1,
                MapsetId = -1,
                Map = "Artist - Title [Example]",
                JudgementCount = 1000,
                HostId = 7,
                PlayersReady = new List<int>() { 3, 6, 13, 7 },
                RedTeamPlayers = new List<int> { 0, 1, 2, 3, 4, 5, 6, },
                BlueTeamPlayers = new List<int> { 7, 8, 9, 10, 11, 12, 13, 14 },
                PlayersWithoutMap = new List<int>()
                {
                    8, 9, 7, 2
                },
                PlayerMods = new List<MultiplayerPlayerMods>()
                {
                    new MultiplayerPlayerMods()
                    {
                        UserId = 2,
                        Modifiers = ((long) (ModIdentifier.NoFail)).ToString()
                    },
                    new MultiplayerPlayerMods()
                    {
                        UserId = 3,
                        Modifiers = ((long) (ModIdentifier.Mirror | ModIdentifier.Speed07X)).ToString()
                    }
                },
                PlayerWins = new List<MultiplayerPlayerWins>()
                {
                    new MultiplayerPlayerWins()
                    {
                        UserId = 0,
                        Wins = 6
                    },
                    new MultiplayerPlayerWins()
                    {
                        UserId = 5,
                        Wins = 47
                    }
                },
                RefereeUserId = 15
            };
        }
    }
}