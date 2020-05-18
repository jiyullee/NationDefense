using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM3 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "제천시")
        {
            new Skill_Jechun().UseSkill();
        }
        else if (city.CityName == "통영시")
        {
            new Skill_Tongyeong().UseSkill();
        }
        else if (city.CityName == "논산시")
        {
            new Skill_Nonsan().UseSkill();
        }
        else if (city.CityName == "사천시")
        {
            new Skill_Sachun().UseSkill();
        }
        else if (city.CityName == "여주시")
        {
            new Skill_Yeoju().UseSkill();
        }
        else if (city.CityName == "공주시")
        {
            new Skill_Gongju().UseSkill();
        }
        else if (city.CityName == "정읍시")
        {
            new Skill_Jeongeup().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Jechun : Skill_AM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Tongyeong : Skill_AM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Nonsan : Skill_AM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Sachun : Skill_AM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Yeoju : Skill_AM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Gongju : Skill_AM3
{

    public override void UseSkill()
    {

    }
}

public class Skill_Jeongeup: Skill_AM3
{

    public override void UseSkill()
    {

    }
}

