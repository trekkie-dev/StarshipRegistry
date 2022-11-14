namespace StarshipRegistryGUI.Main_Feature_Classes
    {
    public class RegisterStarship
        {

        public RegisterStarship()
            {

            }

        public string? affiliation;
        public string? shipOperator;
        public string? shipClass;
        public string? ShipName;
        public string? registryNum;
        public string? primaryWeapons;
        public string? defenses;
        public string? mostRecentCaptain;
        public string? firstOfficer;
        public string? cruisingSpeed;
        public string? topSpeed;
        public string? numberOfDecks;
        public string? crewCompliment;
        public string? isPrototype;
        public string? serviceStatus;

        public RegisterStarship(string rowData)
            {
            string[] reg = rowData.Split(',');
            this.affiliation = reg[0];
            this.shipOperator = reg[1];
            this.shipClass = reg[2];
            this.ShipName = reg[3];
            this.registryNum = reg[4];
            this.primaryWeapons = reg[5];
            this.defenses = reg[6];
            this.mostRecentCaptain = reg[7];
            this.firstOfficer = reg[8];
            this.cruisingSpeed = reg[9];
            this.topSpeed = reg[10];
            this.numberOfDecks = reg[11];
            this.crewCompliment = reg[12];
            this.isPrototype = reg[13];
            this.serviceStatus = reg[14];
            }
        public override string ToString()
            {
            string regShip = $"GOVERNMENT AFFILIATION:   {affiliation}" + "\n" +
            $"SHIP OPERATOR:   {shipOperator}" + "\n" +
            $"CLASS:   {shipClass}" + "\n" +
            $"SHIP DESIGNATION:   {ShipName}" + "\n" +
            $"REGISTRY NUMBER:   {registryNum}" + "\n" +
            $"PRIMARY WEAPONRY:   {primaryWeapons}" + "\n" +
            $"DEFENSE CAPABILITIES:   {defenses}" + "\n" +
            $"CAPTAIN:   {mostRecentCaptain}" + "\n" +
            $"FIRST OFFICER:   {firstOfficer}" + "\n" +
            $"CRUISING SPEED:   {cruisingSpeed}" + "\n" +
            $"TOP SPEED:   {topSpeed}" + "\n" +
            $"DECKS:   {numberOfDecks}" + " DECKS" + "\n" +
            $"CREW COMPLIMENT:   {crewCompliment}" + "\n" +
            $"PROTOTYPE VESSEL:   {isPrototype}" + "\n" +
            $"SERVICE STATUS:   {serviceStatus}";
            return regShip;
            }

        public bool Save()
            {
            return true;
            }
        }
    }
