using System;
public class Student
{
    private int _id;
    private int passmarks;
    private string name;
   // private int regno;

    public void SetId(int Id)
    {
        if (Id < 0)
        {
            throw new Exception("Can't be a negative value");
        }
        this._id = Id;
    }
    public int GetId()
    {
        return this._id;
        //return this.passmarks;

    }
    public void SetPm(int Pm)
    {
        if(Pm < 33)
        {
            throw new Exception("Pass Marks is 33");
        }
        this.passmarks = Pm;
    }
    public int GetPm()
    {
        return this.passmarks;
    }

    public void Setnm(string nm)
    {
        if(nm == null)
        {
            throw new ArgumentNullException("Can't be null value");
        }
        this.name= nm;
    }
    public string Getnm()
    {
        return this.name;
    }
}

public class property
{
    public static void Main()
    {
        Student S = new Student();
        S.SetId(100);
        S.SetPm(33);
        S.Setnm("Ayush");

        Console.WriteLine("StudentID ={0},\nStudent_Passmarks={1},\nStudent_Name={2}",S.GetId(),S.GetPm(),S.Getnm());

    }
}