using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [Key]
    public int studentID { get; set; }

    public string First_Name { get; set; }
    public string middle_name { get; set; }
    public string last_name { get; set; }
    public DateTime birthday_date { get; set; }
    public int educationID { get; set; }
    public int compositionID { get; set; }
    public string LivingAddress { get; set; }
    public DateTime Registration_start_date { get; set; }
}
public class grade

{
    [Key]
    public int studentID { get; set; }
    public string Maths_grades{get;set;}
    public string Russian_language { get; set; }
    public string litra { get; set; }
    public string fizra { get; set; }
    public string it { get; set; }
    public string izo { get; set; }
    public string technologia { get; set; }
    public string obsh { get; set; }
    public string english_lang { get; set; }
    public string history { get; set; }
}
public class Education
{
    [Key]
    public int educationID { get; set; }

    public string name_of_education_institution { get; set; }
    public string address_of_educational_institution { get; set; }
    public DateTime endDate { get; set; }
    
}

public class Parents
{
    [Key]
    public int parentID { get; set; }
    public int studentID { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set;}
    public string Middle_Name { get; set; }
    public string jobPlace { get; set; }
    public string job_Title { get; set; }
    public string Work_phone { get; set;}
    public string Living_adress { get; set; }

}

public class Composition_Family
{
    [Key]
    public int compositionID { get; set; }

    public string family_completeness { get; set; }
}

public class Creativity_Activity
{
    [Key]
    public int creativityID { get; set; }

    public int type_of_creativity { get; set; }
    public string name_of_creativity { get; set; }


}
public class Eventss
{
    [Key]
    public int eventID { get; set; }
    public string name_of_event { get; set; }
}
public class Participation_in_event

{
    [Key]
    public int studentID { get; set; }
    public int eventID { get; set; }
}

public class PROMPUN
{
    [Key]
    public int promotionID { get;set; }
    public string name_of_promotion { get; set; }
    public string name_of_punishment { get; set; }
    public int studentID { get; set; }
}
public class Students_Promotions
{
    [Key]
    public int studentID { get; set; }
    public int PromotionsID { get; set; }
}
public class Punishment
{
    [Key]
    public int punishmentID { get; set; }
    public string name_of_punishment { get; set; }
}
public class Student_Punishments
{
    [Key]
    public int studentID { get; set; }
    public int punishmentID { get; set; }
    public DateTime datee { get; set; }
}
public class Student_Creativity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int student_creativity { get; set; }
    public int studentID { get; set; }
    public int creativityID { get; set; }
}