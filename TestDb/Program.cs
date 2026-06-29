using System;
using Npgsql;

var connStr = "Host=aws-1-ap-southeast-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.qhaboglgsuklsvgwrbxk;Password=Ufc%.Ge,UUEr4/p;Pooling=true;";

Console.WriteLine("Testing Connection Pooler...");
try
{
    using var conn = new NpgsqlConnection(connStr);
    conn.Open();
    Console.WriteLine("SUCCESS! Connected to Supabase via IPv4 Pooler.");
}
catch (Exception e)
{
    Console.WriteLine($"FAILED: {e.Message}");
}
