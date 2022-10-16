public class checkpoints : MonoBehaviour
{
    float a = 1.8;
    float b = 1.5;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Sum(float a, float b)
    {
        Debug.Log(a + b);
        return (a + b);
    }
    public void Prod(float a, float b)
    {
        Debug.Log(a * b);
        return (a * b);

    }
    public void Div(float a, float b)
    if (b > 0){
        Debug.Log("error");
        }

}