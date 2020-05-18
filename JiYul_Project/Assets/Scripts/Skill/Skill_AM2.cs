using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM2 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "영주시")
        {
            new Skill_YeongJu().UseSkill();
        }
        else if (city.CityName == "나주시")
        {
            new Skill_Naju().UseSkill();
        }
        else if (city.CityName == "밀양시")
        {
            new Skill_Millyang().UseSkill();
        }
        else if (city.CityName == "보령시")
        {
            new Skill_Boryeong().UseSkill();
        }
        else if (city.CityName == "상주시")
        {
            new Skill_Sangju().UseSkill();
        }
        else if (city.CityName == "영천시")
        {
            new Skill_Yeongchun().UseSkill();
        }
        else if (city.CityName == "동두천시")
        {
            new Skill_Dongduchun().UseSkill();
        }
        else if (city.CityName == "동해시")
        {
            new Skill_Donghae().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_YeongJu : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Naju : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Millyang : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Boryeong : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Sangju : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Yeongchun : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Dongduchun : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

public class Skill_Donghae : Skill_AM2
{

    public override void UseSkill()
    {

    }
}

