# DivisionWCF

WCF Service -> Division
.NET / FAULT Exception
Create Fault contract
Basic HttpBinding / WSHttpBinding


Add this to  app.config in host to cancel security under service.serviceModel
<!-- no security -->
    <bindings> 
      <wsHttpBinding>
        <binding name="ws">
          <security mode="None"/>
        </binding>
      </wsHttpBinding>
    </bindings>
And update enpoint by adding attribute bindingConfiguration

<endpoint address="" binding="wsHttpBinding" contract="DivService.IService1" bindingConfiguration="ws" />
