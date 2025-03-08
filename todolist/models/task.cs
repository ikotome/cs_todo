using System;

namespace todolist.models;

public class Task
{

    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Limitdate { get; set; }
    public enum Taskstatus { 
        Todo, Doing, Done
    }
    public Taskstatus Status { get; set; }
}
