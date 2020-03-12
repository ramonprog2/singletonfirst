Public Class LabelSingleton
  
    {
    Private Static Singleton instance = null;
    Private Static ReadOnly Object padlock = New Object();

    Singleton()
    {
    }

    Public Static Singleton Instance
    {
    Get
    {
    lock (padlock)
    {
    If (instance == null)
    {
    instance = New Singleton();
    }
    Return instance;
    }
    }
    }
    }

End Class
