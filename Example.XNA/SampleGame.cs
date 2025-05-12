using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpImGui;
using SharpImGuizmo;
using SharpImNodes;
using SharpImPlot;
using SharpImPlot3D;
using Num = System.Numerics;

namespace Example.XNA
{
    /// <summary>
    /// Simple FNA + ImGui example
    /// </summary>
    public class SampleGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private ImGuiRenderer _imGuiRenderer;

        private Texture2D _xnaTexture;
        private ulong _imGuiTexture;

        public SampleGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1024;
            _graphics.PreferredBackBufferHeight = 768;
            _graphics.PreferMultiSampling = true;

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _imGuiRenderer = new ImGuiRenderer(this);
            _imGuiRenderer.RebuildFontAtlas();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Texture loading example

			// First, load the texture as a Texture2D (can also be done using the XNA/FNA content pipeline)
			_xnaTexture = CreateTexture(GraphicsDevice, 300, 150, pixel =>
			{
				var red = (pixel % 300) / 2;
				return new Color(red, 1, 1);
			});

			// Then, bind it to an ImGui-friendly pointer, that we can use during regular ImGui.** calls (see below)
			_imGuiTexture = _imGuiRenderer.BindTexture(_xnaTexture);

            base.LoadContent();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(clear_color.X, clear_color.Y, clear_color.Z));

            // Call BeforeLayout first to set things up
            _imGuiRenderer.BeforeLayout(gameTime);

            // Draw our UI
            ImGuiLayout();

            // Call AfterLayout now to finish up and draw all the things
            _imGuiRenderer.AfterLayout();

            base.Draw(gameTime);
        }

        // Direct port of the example at https://github.com/ocornut/imgui/blob/master/examples/sdl_opengl2_example/main.cpp
        private float f = 0.0f;

        private bool show_test_window;
        private bool show_another_window;
        private bool show_implot;
        private bool show_implot3d;
        private bool show_imnodes;
        private bool show_imguizmo;
        private Num.Vector3 clear_color = new(114f / 255f, 144f / 255f, 154f / 255f);
        private byte[] _textBuffer = new byte[100];

        protected virtual void ImGuiLayout()
        {
            // 1. Show a simple window
            // Tip: if we don't call ImGui.Begin()/ImGui.End() the widgets appears in a window automatically called "Debug"
            {
                ImGui.Text("Hello, world!"u8);
                ImGui.SliderFloat("float", ref f, 0.0f, 1.0f, string.Empty);
                ImGui.ColorEdit3("clear color", ref clear_color);
                if (ImGui.Button("Test Window")) show_test_window = !show_test_window;
                if (ImGui.Button("Another Window")) show_another_window = !show_another_window;
                if (ImGui.Button("ImPlot")) show_implot = !show_implot;
                if (ImGui.Button("ImPlot3D")) show_implot3d = !show_implot3d;
                if (ImGui.Button("Imnodes")) show_imnodes = !show_imnodes;
                if (ImGui.Button("ImGuizmo")) show_imguizmo = !show_imguizmo;
                ImGui.Text($"Application average {1000f / ImGui.GetIO().Framerate:F3} ms/frame ({ImGui.GetIO().Framerate:F1} FPS)");
                
                ImGui.InputText("Text input", _textBuffer, 100);

                ImGui.Text("Texture sample");
                ImGui.ImageWithBg(_imGuiTexture, new Num.Vector2(300, 150), Num.Vector2.Zero, Num.Vector2.One, Num.Vector4.One, Num.Vector4.One); // Here, the previously loaded texture is used
            }

            // 2. Show another simple window, this time using an explicit Begin/End pair
            if (show_another_window)
            {
                ImGui.SetNextWindowSize(new Num.Vector2(200, 100), ImGuiCond.FirstUseEver);
                ImGui.Begin("Another Window", ref show_another_window);
                ImGui.Text("Hello");
                ImGui.End();
            }

            // 3. Show the ImGui test window. Most of the sample code is in ImGui.ShowTestWindow()
            if (show_test_window)
            {
                ImGui.SetNextWindowPos(new Num.Vector2(650, 20), ImGuiCond.FirstUseEver);
                ImGui.ShowDemoWindow(ref show_test_window);
            }

            if (show_implot)
            {
	            // ImPlot.ShowDemoWindow(ref show_implot);
	            ImGui.Begin("ImPlot", ref show_implot);

	            if (ImPlot.BeginPlot("My Plot", new Num.Vector2(-1, 0), ImPlotFlags.NoInputs))
	            {
		            var labelId = "My plots"u8;
		            ReadOnlySpan<int> xs = [1, 10, 20, 32];
		            ReadOnlySpan<int> ys = [0, 5, 5, 15];
		            var count = 4;
		            var barSize = 5;
		            var flags = ImPlotBarsFlags.None;
		            var offset = 0;
		            var stride = 4;
	      
		            unsafe
		            {
			            fixed (byte* nativeLabelId = labelId)
			            fixed (int* nativeXs = xs)
			            fixed (int* nativeYs = ys)
			            {
							ImPlotNative.PlotBarsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			            }
		            }
		            
		            ImPlot.EndPlot();
	            }
	            
	            ImGui.End();
            }

            if (show_implot3d)
            {
	            ImPlot3D.ShowDemoWindow();
            }
            
            if (show_imnodes)
            {
	            ImGui.Begin("node editor");
	            ImNodes.ImNodesBeginNodeEditor();
	            
	            ImNodes.ImNodesBeginNode(1);
	            ImGui.Dummy(new Num.Vector2(80, 45));
	            ImNodes.ImNodesEndNode();
	            
	            ImNodes.ImNodesEndNodeEditor();
	            ImGui.End();
            }
            
            if (show_imguizmo)
            {
	            
            }
        }

		public static Texture2D CreateTexture(GraphicsDevice device, int width, int height, Func<int, Color> paint)
		{
			//initialize a texture
			var texture = new Texture2D(device, width, height);

			//the array holds the color for each pixel in the texture
			Color[] data = new Color[width * height];
			for(var pixel = 0; pixel < data.Length; pixel++)
			{
				//the function applies the color according to the specified pixel
				data[pixel] = paint( pixel );
			}

			//set the color
			texture.SetData( data );

			return texture;
		}
	}
}