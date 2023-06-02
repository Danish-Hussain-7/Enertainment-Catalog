interface ITvshow
{
    string Name { get; set; }
    float Seasons { get; set; }
}

interface ICast
{
    string Name { get; set; }
    string Gender { get; set; }

    float Age { get; set; }
}

[Serializable]
class tv : ITvshow
{
    public string Name { get; set; }
    public float Seasons { get; set; }
}

[Serializable]
class Cast : ICast
{
    public string Name { get; set; }
    public string Gender { get; set; }

    public float Age { get; set; }
}

[Serializable]
class Tvshow : tv, ITvshow
{
    public List<Cast> Casts { get; set; }

    public Tvshow(string name, float seasons)
    {
        Name = name;
        Seasons = seasons;
    }

    public Tvshow()
    {
    }

}