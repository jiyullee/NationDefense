using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM7 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "성남시")
        {
            new Skill_Sungnam().UseSkill();
        }
        else if (city.CityName == "청주시")
        {
            new Skill_Cheongju().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Sungnam : Skill_PM7
{

    public override void UseSkill()
    {

    }
}

public class Skill_Cheongju : Skill_PM7
{

    public override void UseSkill()
    {

    }
}
