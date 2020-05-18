using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM4 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "안동시")
        {
            new Skill_Andong().UseSkill();
        }
        else if (city.CityName == "포천시")
        {
            new Skill_Pochun().UseSkill();
        }
        else if (city.CityName == "의왕시")
        {
            new Skill_Uiwang().UseSkill();
        }
        else if (city.CityName == "광양시")
        {
            new Skill_Gwangyang().UseSkill();
        }
        else if (city.CityName == "김천시")
        {
            new Skill_Gimchun().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Andong : Skill_AM4
{

    public override void UseSkill()
    {

    }
}

public class Skill_Pochun : Skill_AM4
{

    public override void UseSkill()
    {

    }
}

public class Skill_Uiwang : Skill_AM4
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gwangyang : Skill_AM4
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gimchun : Skill_AM4
{

    public override void UseSkill()
    {

    }
}

