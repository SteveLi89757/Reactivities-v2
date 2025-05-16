using System;
using Domain;
using AutoMapper;


public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
    }
}
