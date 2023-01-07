namespace Admin;
using kisranCart;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class DataManagemant{

    public static void serializationFile(List<KisanRegister> list){
        var filepath=@"D:\IACSD pritam\Dot NET\pritamDotNet\day9\registerList.json";
        var jsonKisan=JsonSerializer.Serialize<List<KisanRegister>>(list);
        File.WriteAllText(filepath,jsonKisan);
    }

    public static List<KisanRegister> GetAllRegisterData(){
   
        var filepath=@"D:\IACSD pritam\Dot NET\pritamDotNet\day9\registerList.json";
        string jsonString=File.ReadAllText(filepath);
       
        
         List<KisanRegister> jsonList=JsonSerializer.Deserialize<List<KisanRegister>>(jsonString);
         return jsonList;

    }
}