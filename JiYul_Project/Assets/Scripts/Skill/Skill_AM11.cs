using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM11 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "진주시")
        {
            new Skill_Jinju().UseSkill();
        }
        else if (city.CityName == "광명시")
        {
            new Skill_Gwangmyeong().UseSkill();
        }
        else if (city.CityName == "아산시")
        {
            new Skill_Asan().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Jinju: Skill_AM11
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gwangmyeong : Skill_AM11
{

    public override void UseSkill()
    {

    }
}

public class Skill_Asan : Skill_AM11
{

    public override void UseSkill()
    {

    }
}

