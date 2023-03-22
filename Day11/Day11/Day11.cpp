#include <iostream>
#include <vector>
using namespace std;//generally considered to be not-professional

enum Suits
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
};
int main()
{
    Suits cardSuit = Spades;
    //std -- standard namespace
    //:: -- scope resolution operator
    //cout -- console output stream
    //<< -- insertion operator.
    std::cout << "Hello World!\n" << "Batman is GREATER than Aquaman\n" << 5 << "\n";
    printf("my age: %d", 12);

    int age = 12;
    float salary = 35000.50;
    char b = 'b';//chars are 1 byte in size
    double dNum = 12.3;
    
    cout << "\n";
    char best[] = "Batman";//adds a \0 (null terminator)
    char meh[] = { 'A','q','u','a','m','a','n', '\0'};
    cout << best << "\n" << meh << "\n";

    for (int i = 0; i < 6; i++)
    {
        cout << best[i] << ".";
    }
    cout << "\n";
    int j = 0;
    while (j < 7)
    {
        cout << meh[j] << ".";
        break;
    }
    do
    {

    } while (j < 7);
    for (char a : best)
    {

    }

    vector<int> highScores;//stack vector
    highScores.push_back(5);//Add
    highScores.push_back(rand());
    highScores.push_back(rand());
    highScores.push_back(rand());
    highScores.push_back(rand());

    for (size_t i = 0; i < highScores.size(); i++)
    {
        cout << highScores[i] << "\n";
    }
}