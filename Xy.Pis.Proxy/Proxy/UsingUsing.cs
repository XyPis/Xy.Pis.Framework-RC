using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Client.Proxy
{
    public class UsingUsing
    {
        // This method shows the correct way to clean up a client, including catching the
        // approprate Exceptions.
        static void DemonstrateCleanupWithExceptions()
        {
            // Create a client
            CalculatorClient client = new CalculatorClient();
            try
            {
                // Demonstrate a successful client call.
                Console.WriteLine("Calling client.Add(0.0, 0.0);");
                double addValue = client.Add(0.0, 0.0);
                Console.WriteLine("        client.Add(0.0, 0.0); returned {0}", addValue);

                // Demonstrate a failed client call.
                Console.WriteLine("Calling client.Divide(0.0, 0.0);");
                double divideValue = client.Divide(0.0, 0.0);
                Console.WriteLine("        client.Divide(0.0, 0.0); returned {0}", divideValue);

                // Do a clean shutdown if everything works.  In this sample we do not end up
                // here, but correct code should Close the client if everything was successful.
                Console.WriteLine("Closing the client");
                client.Close();
            }
            catch (CommunicationException e)
            {
                // Because the server suffered an internal server error, it rudely terminated
                // our connection, so we get a CommunicationException.
                Console.WriteLine("Got {0} from Divide.", e.GetType());
                client.Abort();
            }
            catch (TimeoutException e)
            {
                // In this sample we do not end up here, but correct code should catch
                // TimeoutException when calling a client.
                Console.WriteLine("Got {0} from Divide.", e.GetType());
                client.Abort();
            }
            catch (Exception e)
            {
                // In this sample we do not end up here.  It is best practice to clean up the
                // client if some unexpected Exception occurs.
                Console.WriteLine("Got unexpected {0} from Divide, rethrowing.", e.GetType());
                client.Abort();
                throw;
            }
        }
    }
}
