using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM7 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "거제시")
        {
            new Skill_Geoje().UseSkill();
        }
        else if (city.CityName == "목포시")
        {
            new Skill_Mokpo().UseSkill();
        }
        else if (city.CityName == "오산시")
        {
            new Skill_Osan().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_Geoje : Skill_AM7
{

    public override void UseSkill()
    {

    }
}

public class Skill_Mokpo : Skill_AM7
{

    public override void UseSkill()
    {

    }
}

public class Skill_Osan : Skill_AM7
{

    public override void UseSkill()
    {

    }
}

