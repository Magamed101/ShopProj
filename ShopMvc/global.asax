<%@ Application Language="C#" %>

<script runat="server">

      void Application_Start(object sender, EventArgs e) 
    {
        Application.Add("userCount", 0);
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
    }
    void Session_Start(object sender, EventArgs e) 
    {
        int userCount = int.Parse(Application.Get("userCount").ToString());
        userCount++;
        Application.Set("userCount", userCount);
    }
    void Session_End(object sender, EventArgs e) 
    {
        int userCount = int.Parse(Application.Get("userCount").ToString());
        userCount--;
        Application.Set("userCount", userCount);
    }
       
</script>