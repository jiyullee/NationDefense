using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM3 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "안양시")
        {
            new Skill_Anyang().UseSkill();
        }
        else if (city.CityName == "김해시")
        {
            new Skill_Gimhae().UseSkill();
        }
        else if (city.CityName == "평택시")
        {
            new Skill_Pyeongtaek().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Anyang : Skill_PM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gimhae : Skill_PM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Pyeongtaek : Skill_PM3
{

    public override void UseSkill()
    {

    }
}


