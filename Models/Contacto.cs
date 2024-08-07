public class ContactoClase
{
    
    public static List<Usuarios> usuario { get; set; } = new List<Usuarios> { };
    public static List<string> Imagenes { get; private set; } = new List<string>{

    "../Images/programacion.png", "../Images/deport.png","../Images/viajar.png", "../Images/musica.png"
};
    public static List<string> Textos { get; private set; } = new List<string>{

    "Me apasiona la programación porque me permite ser creativo y construir soluciones únicas desde cero, transformando ideas en aplicaciones funcionales. Disfruto del desafío de resolver problemas complejos y la satisfacción que conlleva encontrar soluciones efectivas. La constante evolución de la tecnología me motiva a aprender continuamente y mejorar mis habilidades. Además, me encanta la posibilidad de tener un impacto positivo en el mundo a través de mis proyectos, y valoro la autonomía y flexibilidad que esta disciplina ofrece.",
    "Me apasiona el deporte porque me permite mantenerme activo y saludable, además de ofrecerme la oportunidad de superarme constantemente. Disfruto el desafío físico y mental que conlleva, así como la camaradería y el trabajo en equipo. El deporte también me enseña disciplina, resiliencia y la importancia de fijar y alcanzar metas.",
    "Me apasiona viajar porque me permite descubrir nuevas culturas, conocer personas interesantes y experimentar diferentes formas de vida. Disfruto la emoción de explorar lugares desconocidos, probar comidas exóticas y aprender sobre la historia y las tradiciones de cada destino. Viajar me abre la mente, me enriquece personalmente y me enseña a apreciar la diversidad del mundo.",
    "Me apasiona la música porque tiene el poder de expresar emociones y conectar a las personas de una manera única. Disfruto de la creatividad que implica componer y tocar instrumentos, así como la capacidad de la música para contar historias y evocar recuerdos. La música enriquece mi vida, me inspira y me proporciona un escape del día a día."
};
public static List<string> Titulos { get; private set; } = new List<string>{
    "Programación","Deportes", "Viajar", "La musica"
};
    public static void IngresarUsuario(string region, Usuarios usuario)
    {}

}
