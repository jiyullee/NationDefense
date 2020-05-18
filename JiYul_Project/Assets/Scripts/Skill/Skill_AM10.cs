using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM10 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "익산시")
        {
            new Skill_Iksan().UseSkill();
        }
        else if (city.CityName == "춘천시")
        {
            new Skill_Chuncheon().UseSkill();
        }
        else if (city.CityName == "경산시")
        {
            new Skill_Gyeongsan().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Iksan : Skill_AM10
{

    public override void UseSkill()
    {

    }
}

public class Skill_Chuncheon : Skill_AM10
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gyeongsan : Skill_AM10
{

    public override void UseSkill()
    {

    }
}

