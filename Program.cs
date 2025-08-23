using SDL3;

namespace CSharp_SDL3_Sample
{
    internal class Program
    {
        static nint window;
        static nint renderer;

        static void Main(string[] args)
        {
            if (!SDL.SDL_Init(SDL.SDL_InitFlags.SDL_INIT_VIDEO))
            {
                Console.WriteLine("oh no!");
            }
            //Console.WriteLine("Hello, World!");

            /*/
            nint window = SDL.SDL_CreateWindow("ONION", 100, 100, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
            Console.WriteLine("Window: " + window); // TODO: Error Handling

            // THIS DIDN'T WORK
            nint renderer = SDL.SDL_CreateRenderer(window, "WINDEEZ");
            Console.WriteLine("Renderer: "+renderer); // TODO: Error Handling
            /**/


            // This might be an SDL3 version, renderer actually appeared
            //nint WINDOW, RENDERER;
            SDL.SDL_CreateWindowAndRenderer("YORE GAIM", 1000, 1000, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE, out nint WINDOW, out nint RENDERER);
            //Console.WriteLine("W:"+WINDOW+" R:"+RENDERER);
            
            // SDL2 Copy
            bool running = true;
            while (running) {
                // Check to see if there are any events and continue to do so until the queue is empty.
                while (SDL.SDL_PollEvent(out SDL.SDL_Event e)) {
                    switch (e.type) {
                        case (uint)SDL.SDL_EventType.SDL_EVENT_QUIT:
                            running = false;
                            break;
                    }
                }

                // Sets the color that the screen will be cleared with.
                SDL.SDL_SetRenderDrawColor(RENDERER, 0, 255, 0, 255);
                // TODO Error Check

                // Clears the current render surface.
                SDL.SDL_RenderClear(RENDERER);
                // TODO Error Check

                // Switches out the currently presented render surface with the one we just did work on.
                SDL.SDL_RenderPresent(RENDERER);
            }


            //Console.WriteLine(SDL.SDL_GetError());

            //SDL.SDL_DestroyWindow(window);
            SDL.SDL_DestroyWindow(WINDOW);
            SDL.SDL_DestroyRenderer(RENDERER);
            SDL.SDL_Quit();
        }
    }
}
