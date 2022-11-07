public class Starships
    {
    public string affiliation;
    public string shipOperator;
    public string shipClass;
    public string ShipName;
    public string registryNum;
    public string primaryWeapons;
    public string defenses;
    public string mostRecentCaptain;
    public string firstOfficer;
    public string cruisingSpeed;
    public string topSpeed;
    public string numberOfDecks;
    public string crewCompliment;
    public string isPrototype;
    public string serviceStatus;

    public Starships(string rows)
        {

        string[] shipData = rows.Split(',');

        // Parse Data
        this.affiliation = shipData[0];
        this.shipOperator = shipData[1];
        this.shipClass = shipData[2];
        this.ShipName = shipData[3];
        this.registryNum = shipData[4];
        this.primaryWeapons = shipData[5];
        this.defenses = shipData[6];
        this.mostRecentCaptain = shipData[7];
        this.firstOfficer = shipData[8];
        this.cruisingSpeed = shipData[9];
        this.topSpeed = shipData[10];
        this.numberOfDecks = shipData[11];
        this.crewCompliment = shipData[12];
        this.isPrototype = shipData[13];
        this.serviceStatus = shipData[14];
        }


    public override string ToString()
        {
        string ship = $"GOVERNMENT AFFILIATION:   {affiliation}" + "\n" +
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
            $"DECKS:   {numberOfDecks}" + "\n" +
            $"CREW COMPLIMENT:   {crewCompliment}" + "\n" +
            $"PROTOTYPE VESSEL:   {isPrototype}" + "\n" +
            $"SERVICE STATUS:   {serviceStatus}";
        return ship;
        }
    }

