using System.Runtime.InteropServices;

namespace SharpBack
{ 

    internal class Program
    {
        const string patchAPI = "D:\\Projects\\PartTimeJobPortal\\PartTimeJobPortal\\x64\\Debug\\LibraryAPI.dll";

        [DllImport(patchAPI, CallingConvention = CallingConvention.Cdecl)]
        public static extern int summ(long a, long b);

        [DllImport(patchAPI, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr getName();

        static void Main(string[] args)
        {
            const long A = 50;
            const long B = 200;
            long result = summ(A, B);
            IntPtr namePtr = getName();
            string name = Marshal.PtrToStringAnsi(namePtr);
            Console.WriteLine($"{name} result of SUMM({A}, {B}): {result}");
        }
    }

}
