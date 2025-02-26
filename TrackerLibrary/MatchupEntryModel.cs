namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCometing { get; set; }

        public double Score { get; set; }

        public MatchupModel ParentMatchup { get; set; }
    }
}