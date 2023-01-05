namespace BL;

public interface IBusinessLayer<T>
{
    T Add (T p_resource);
    T Delete (T p_resource);
    T Update (T p_resource);
    List<T> GetAll ();
}