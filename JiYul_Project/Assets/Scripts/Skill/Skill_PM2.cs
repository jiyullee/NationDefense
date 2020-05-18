using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM2 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "포항시")
        {
            new Skill_Pohang().UseSkill();
        }
        else if (city.CityName == "시흥시")
        {
            new Skill_Siheung().UseSkill();
        }
        else if (city.CityName == "파주시")
        {
            new Skill_Paju().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Pohang : Skill_PM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Siheung : Skill_PM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Paju : Skill_PM2
{

    public override void UseSkill()
    {

    }
}


