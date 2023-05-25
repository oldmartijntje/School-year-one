﻿public class Trainer
{
    public string Name { get; }
    public List<Pokeball> Belt { get; set; }
    public Pokemon? ActivePokemon { get; set; }
    public int? ActivePokemonBeltId { get; set; }

    public Trainer(string name, List<Pokeball> belt)
    {
        Belt = belt.Take(6).ToList();
        Name = name;
    }
}