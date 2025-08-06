using SDL3;

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
            //Console.WriteLine("Hello, World!");

            /*/
            nint window = SDL3.SDL.SDL_CreateWindow("ONION", 100, 100, SDL3.SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
            Console.WriteLine("Window: " + window); // TODO: Error Handling

            // THIS DIDN'T WORK
            nint renderer = SDL3.SDL.SDL_CreateRenderer(window, "WINDEEZ");
            Console.WriteLine("Renderer: "+renderer); // TODO: Error Handling
            /**/


            // This might be an SDL3 version, renderer actually appeared
            //nint WINDOW, RENDERER;
            SDL3.SDL.SDL_CreateWindowAndRenderer("YORE GAIM", 1000, 1000, SDL3.SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE, out nint WINDOW, out nint RENDERER);
            //Console.WriteLine("W:"+WINDOW+" R:"+RENDERER);
            
            // SDL2 Copy
            bool running = true;
            while (running) {
                // Check to see if there are any events and continue to do so until the queue is empty.
                while (SDL3.SDL.SDL_PollEvent(out SDL3.SDL.SDL_Event e)) {
                    switch (e.type) {
                        case (uint)SDL3.SDL.SDL_EventType.SDL_EVENT_QUIT:
                            running = false;
                            break;
                    }
                }

                // Sets the color that the screen will be cleared with.
                SDL3.SDL.SDL_SetRenderDrawColor(RENDERER, 0, 255, 0, 255);
                // TODO Error Check

                // Clears the current render surface.
                SDL3.SDL.SDL_RenderClear(RENDERER);
                // TODO Error Check

                // Switches out the currently presented render surface with the one we just did work on.
                SDL3.SDL.SDL_RenderPresent(RENDERER);
            }


            //Console.WriteLine(SDL3.SDL.SDL_GetError());

            //SDL3.SDL.SDL_DestroyWindow(window);
            SDL3.SDL.SDL_DestroyWindow(WINDOW);
            SDL3.SDL.SDL_DestroyRenderer(RENDERER);
            SDL3.SDL.SDL_Quit();
        }
    }
}
