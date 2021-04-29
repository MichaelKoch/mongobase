﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mongo2Go;
using MongoBase.Repositories;
using MongoBase.Test;
using MongoBase.Test.Models;

[TestClass]
public class Setup
{

    public static MongoDbRunner mongoInstance = null;
    [AssemblyInitialize]
    public static void InitializeTestRun(TestContext context)
    {
        mongoInstance =  Mongo2Go.MongoDbRunner.Start(singleNodeReplSet: true);
        ConfigHelper._config.ConnectionString = mongoInstance.ConnectionString;      
    }
    [AssemblyCleanup]
    public static void Dispose()
    {
        mongoInstance.Dispose();
    }

    [TestInitialize] //this doesn't work!
    public static void InitializeTest()
    {
        //... code that runs before each test
    }
}