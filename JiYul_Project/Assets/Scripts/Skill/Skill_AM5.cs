using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM5 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "충주시")
        {
            new Skill_Chungju().UseSkill();
        }
        else if (city.CityName == "안성시")
        {
            new Skill_Anseong().UseSkill();
        }
        else if (city.CityName == "구리시")
        {
            new Skill_Guree().UseSkill();
        }
        else if (city.CityName == "서산시")
        {
            new Skill_Seosan().UseSkill();
        }
        else if (city.CityName == "당진시")
        {
            new Skill_Dangjin().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Chungju : Skill_AM5
{

    public override void UseSkill()
    {

    }
}

public class Skill_Anseong : Skill_AM5
{

    public override void UseSkill()
    {

    }
}

public class Skill_Guree : Skill_AM5
{

    public override void UseSkill()
    {

    }
}

public class Skill_Seosan : Skill_AM5
{

    public override void UseSkill()
    {

    }
}

public class Skill_Dangjin : Skill_AM5
{

    public override void UseSkill()
    {

    }
}
