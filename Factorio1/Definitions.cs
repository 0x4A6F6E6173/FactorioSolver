namespace Factorio
{
    /*
    public class Product { string name; List<string> requirements; float productionSpeed; }
    public class Research
    {
        public string name;
        public List<string> requirements;
        public List<Research> deeperNodes;
        public float unitResearchSpeed;
        public int productionCost;

        public Research(string name, List<string> requirements, float unitProductionSpeed, int productionCost)
        {
            this.name = name;
            this.requirements = requirements;
            this.deeperNodes = new List<Research>();
            this.unitResearchSpeed = unitProductionSpeed;
            this.productionCost = productionCost;
        }
    }

    public static Research PopulateResearchTree()
    {
        Research researchTree = new Research("Null Node", new List<String> {"Automation Science Pack"}, 0, 0);
        Research Automation = new Research("Automation", new List<String> { "Automation Science Pack" }, 10, 10);
        Research Optics = new Research("Optics", new List<String> { "Automation Science Pack" }, 15, 10);
        Research Gun_Turret = new Research("Gun Turret", new List<String> { "Automation Science Pack" }, 10, 10);
        Research Stone_Wall = new Research("Stone Wall", new List<String> { "Automation Science Pack" }, 10, 10);
        Research Military = new Research("Military", new List<String> { "Automation Science Pack" }, 15, 10);
        Research Logistics = new Research("Logistics", new List<String> { "Automation Science Pack" }, 15, 20);
        Research Steel_Processing = new Research("Steel Processing", new List<String> { "Automation Science Pack" }, 5, 50);

        Research Logistic_Science_Pack = new Research("Logistic Science Pack", new List<String> { "Automation Science Pack" }, 5, 75);
        Research Electronics = new Research("Electronics", new List<String> { "Automation Science Pack" }, 15, 30);
        Research Fast_Inserter = new Research("Fast Inserter", new List<String> { "Automation Science Pack" }, 15, 30);
        Research Heavy_Armor = new Research("Heavy Armor", new List<String> { "Automation Science Pack" }, 30, 30);
        Research Steel_Axe = new Research("Steel Axe", new List<String> { "Automation Science Pack" }, 30, 50);
        Research Weapon_Shooting_Speed_1 = new Research("Weapon Shooting Speed 1", new List<String> { "Automation Science Pack" }, 30, 100);
        Research Physical_Projectile_Damage_1 = new Research("Physical Projectile Damage 1", new List<String> { "Automation Science Pack" }, 30, 100);
        
        Research Military_2 = new Research("Military 2", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Military_Science_Pack = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Automation_2 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Landfill = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Fluid_Handling = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Flammables = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Nightvision_Equipment = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Belt_Immunity_Equipment = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Personsal_Battery = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Speed_Module = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Productivity_Module = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Efficiency_Module = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Chemical_Science_Pack = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Advanced_Material_Processing = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Railway = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Automated_Rail_Transportation = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Circuit_Network = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Explosives = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Gate = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Engine = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Rail_Signals = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research ToolBelt = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Lab_Research_Speed_1 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Oil_Processing = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Automobilism = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Stronger_Explosives_1 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Modular_Armor = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research Portable_Solar_Panel = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Modules = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Logistics_2 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Mining_Productivity_1 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Follower_Robot_Count_1 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Advanced_Oil_Processing = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Personal_Battery_MK2 = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Low_Density_Structure = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Personal_Laser_Defence = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Effect_Transmission = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Logistic_System = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        Research Rocket_Silo = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );
        Research = new Research("", new List<String> { "Automation Science Pack", "Logistic Science Pack" }, , );

        return researchTree;
    }
    */
}