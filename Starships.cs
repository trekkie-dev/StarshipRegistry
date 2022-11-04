public class Starship
    {
    public string affiliation;
    public string shipOperator;
    public string shipClass;
    public string shipName;
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

    public Starship(string rowData)
        {
        string[] vessel = rowData.Split(',');

        this.affiliation = vessel[0];
        this.shipOperator = vessel[1];
        this.shipClass = vessel[2];
        this.shipName = vessel[3];
        this.registryNum = vessel[4];
        this.primaryWeapons = vessel[5];
        this.defenses = vessel[6];
        this.mostRecentCaptain = vessel[7];
        this.firstOfficer = vessel[8];
        this.cruisingSpeed = vessel[9];
        this.topSpeed = vessel[10];
        this.numberOfDecks = vessel[11];
        this.crewCompliment = vessel[12];
        this.isPrototype = vessel[13];
        this.serviceStatus = vessel[14];
        }

    public override string ToString()
        {
        string str = $"Affiliation: {affiliation} \n" +
            $"Ship Operator: {shipOperator} \n" +
            $"Class: {shipClass} \n" +
            $"Ship Operator: {shipOperator} \n" +
            $"Ship Name: {shipName} \n" +
            $"Registry Number: {registryNum} \n" +
            $"Primary Weaponry: {primaryWeapons} \n" +
            $"Defense Capabilities: {defenses} \n" +
            $"Captain: {mostRecentCaptain} \n" +
            $"First Officer: {firstOfficer} \n" +
            $"Cruising Speed: {cruisingSpeed} \n" +
            $"Top Speed: {topSpeed} \n" +
            $"Decks: {numberOfDecks} \n" +
            $"Crew Compliment: {crewCompliment} \n" +
            $"Prototype Vessel: {isPrototype} \n" +
            $"Service Status: {serviceStatus} \n";
        return str;
        }
    }

