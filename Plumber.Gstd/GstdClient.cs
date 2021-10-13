using System.Net.Http.Headers;
using Plumber.Gstd.Entities;

namespace Plumber.Gstd
{
    public class GstdClient
    {
        private static readonly HttpClient Client = new();

        public GstdClient(string uri)
        {
            Client.BaseAddress = new Uri(uri);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// GET
        public async Task<IEnumerable<Pipeline>> GetPipelines()
        {
            throw new NotImplementedException();
        }

        public async Task<Pipeline> GetPipelineGraph(string pipelineId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Element>> GetElements(string pipelineId)
        {
            throw new NotImplementedException();
        }

        public async Task<Element> GetElement(string pipelineId, string elementId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Property>> GetProperties(string pipelineId, string elementId)
        {
            throw new NotImplementedException();
        }

        public async Task<BusMessage> GetBusMessage(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.GetAsync($"pipelines/{pipelineId}/bus/message");
        }

        public async Task<IEnumerable<Signal>> GetSignals(string pipelineId, string elementId)
        {
            throw new NotImplementedException();
            await Client.GetAsync($"pipelines/{pipelineId}/elements/{elementId}/signals");
        }

        public async Task<IEnumerable<Signal>> SignalConnect(string pipelineId, string elementId, string signalId)
        {
            throw new NotImplementedException();
            await Client.GetAsync($"pipelines/{pipelineId}/elements/{elementId}/signals/{signalId}/callback");
        }

        public async Task<IEnumerable<Signal>> SignalDisconnect(string pipelineId, string elementId, string signalId)
        {
            throw new NotImplementedException();
            await Client.GetAsync($"pipelines/{pipelineId}/elements/{elementId}/signals/{signalId}/disconnect");
        }

        /// POST
        public async Task CreatePipeline(string pipelineId, string description)
        {
            throw new NotImplementedException();
            await Client.PostAsync($"pipelines?name={pipelineId}&description={description}",null);
        }

        public async Task SendEOSEvent(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.PostAsync($"pipelines/{pipelineId}/event?name=eos", null);
        }

        public async Task SendFlushStartEvent(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.PostAsync($"pipelines/{pipelineId}/event?name=flush_start", null);
        }

        public async Task SendFlushStopEvent(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.PostAsync($"pipelines/{pipelineId}/event?name=flush_stop", null);
        }

        /// PUT
        public async Task PlayPipeline(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"pipelines/{pipelineId}/state?name=playing", null);
        }

        public async Task PausePipeline(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"pipelines/{pipelineId}/state?name=paused", null);
        }

        public async Task StopPipeline(string pipelineId)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"pipelines/{pipelineId}/state?name=null", null);
        }

        public async Task ElementSet(string pipelineId, string elementId, string propertyId, string value)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"pipelines/{pipelineId}/elements/{elementId}/properties/{propertyId}?name={value}", null);
        }

        public async Task PipelineVerbose(string pipelineId, bool on)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"pipelines/{pipelineId}/verbose?name={on.ToString()}", null);
        }

        public async Task DebugEnable(bool on)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"debug/enable?name={on.ToString()}", null);
        }

        public async Task DebugReset(bool on)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"debug/reset?name={on.ToString()}", null);
        }

        public async Task DebugThreshold(Debug.Threshold threshold)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"debug/threshold?name={threshold}", null);
        }

        public async Task DebugColor(bool on)
        {
            throw new NotImplementedException();
            await Client.PutAsync($"debug/color?name={on.ToString()}", null);
        }




        /*
2.3	PUT
2.3.10	Bus Timeout
2.3.11	Bus Filter
2.3.12	Event Seek
2.3.13	Signal Timeout
2.4	DELETE
2.4.1	Delete Pipeline

         */



    }
}