using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM8 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "여수시")
        {
            new Skill_Yeosoo().UseSkill();
        }
        else if (city.CityName == "순천시")
        {
            new Skill_Soonchun().UseSkill();
        }
        else if (city.CityName == "경주시")
        {
            new Skill_Gyeongju().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Yeosoo : Skill_AM8
{

    public override void UseSkill()
    {

    }
}

public class Skill_Soonchun : Skill_AM8
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gyeongju : Skill_AM8
{

    public override void UseSkill()
    {

    }
}

