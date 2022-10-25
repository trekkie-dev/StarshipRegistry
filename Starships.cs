public class Starships
    {
    public String affiliation;
    public String shipClass;
    public String regNum;
    public String shipName;
    public String currentCaptain;
    public String topSpeed;
    public String cruiseSpeed;
    public String crewComp;
    public bool isExperimental;

    public Starships(string affiliation, string shipClass, string regNum, string shipName, string currentCaptain, string cruiseSpeed, string topSpeed, string crewComp, bool isExperimental)
        {
        this.affiliation = affiliation;
        this.shipClass = shipClass;
        this.regNum = regNum;
        this.shipName = shipName;
        this.currentCaptain = currentCaptain;
        this.cruiseSpeed = cruiseSpeed;
        this.topSpeed = topSpeed;
        this.crewComp = crewComp;
        this.isExperimental = isExperimental;
        }
    }

