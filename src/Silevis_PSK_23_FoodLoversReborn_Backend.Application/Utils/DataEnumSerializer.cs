using Silevis_PSK_23_FoodLoversReborn_Backend.Application.DataEnums;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application.Utils;

public static class DataEnumSerializer
{
    public static ProgrammeTypeEnum? GetProgrammeType(string programmeType)
    {
        if (Enum.TryParse(typeof(ProgrammeTypeEnum), programmeType, out object? result))
        {
            return (ProgrammeTypeEnum)result;
        }
        return null;
    }
    
}