namespace CSharp_SDL3_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (!SDL3.SDL.SDL_Init(SDL3.SDL.SDL_InitFlags.SDL_INIT_VIDEO))
            {
                Console.WriteLine("oh no!");
            }
            Console.WriteLine("Hello, World!");

            SDL3.SDL.SDL_Quit();
        }
    }
}
