﻿using Microsoft.AspNetCore.Identity;

namespace WebAPIAutores.Entidades;

public class LlaveAPI
{
    public int Id{ get; set; }
    public string Llave { get; set; }
    public TipoLlave TipooLlave { get; set; }
    public bool Activa { get; set; }
    public string UsuarioId { get; set; }
    public IdentityUser Usuario{ get; set; }
}

public enum TipoLlave
{
    Gratuita = 1, 
    Profesional = 2
}   
