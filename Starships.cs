public class Starships
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
    public int numberOfDecks;
    public string crewCompliment;
    public string isPrototype;
    public string serviceStatus;

    public Starships(string affiliation, string shipOperator, string shipClass, string shipName, string registryNum, string primaryWeapons, string defenses, string mostRecentCaptain, string firstOfficer, string cruisingSpeed, string topSpeed, int numberOfDecks, string crewCompliment, string isPrototype, string serviceStatus)
        {
        this.affiliation = affiliation;
        this.shipOperator = shipOperator;
        this.shipClass = shipClass;
        this.shipName = shipName;
        this.registryNum = registryNum;
        this.primaryWeapons = primaryWeapons;
        this.defenses = defenses;
        this.mostRecentCaptain = mostRecentCaptain;
        this.firstOfficer = firstOfficer;
        this.cruisingSpeed = cruisingSpeed;
        this.topSpeed = topSpeed;
        this.numberOfDecks = numberOfDecks;
        this.crewCompliment = crewCompliment;
        this.isPrototype = isPrototype;
        this.serviceStatus = serviceStatus;
        }

    }

