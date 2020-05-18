using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM1 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "의정부시")
        {
            new Skill_Uijeongbu().UseSkill();
        }
        else if (city.CityName == "김포시")
        {
            new Skill_Gimpo().UseSkill();
        }
        else if (city.CityName == "구미시")
        {
            new Skill_Gumi().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Uijeongbu : Skill_PM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gimpo : Skill_PM1
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gumi : Skill_PM1
{

    public override void UseSkill()
    {

    }
}

