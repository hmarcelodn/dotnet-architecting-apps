﻿namespace WaterpoloScoring.Framework.Commands
{
    public class ZapArchiveCommand : Command
    {
        public ZapArchiveCommand(string matchId)
        {
            MatchId = matchId;

            // Command class has SagaId property used to find saga the message relates to. 
            // (Simpler schema than more general ConfigureHowToFindSaga method in NServiceBus)
            SagaId = matchId;
        }
        public string MatchId { get; private set; } 
    }
}