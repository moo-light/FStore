using System;
using System.Diagnostics.Metrics;

public interface IMemberRepository
{
    IEnumerable<Member> GetAlls();
    Member Get(int id);
    void Create(Member m);
    void Update(Member m);
    void Remove(Member m);
}
