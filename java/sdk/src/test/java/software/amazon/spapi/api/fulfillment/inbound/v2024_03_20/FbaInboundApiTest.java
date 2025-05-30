/*
 * The Selling Partner API for FBA inbound operations.
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.api.fulfillment.inbound.v2024_03_20;

import software.amazon.spapi.ApiResponse;
import com.amazon.SellingPartnerAPIAA.LWAAuthorizationCredentials;
import org.jeasy.random.EasyRandom;
import org.jeasy.random.EasyRandomParameters;
import org.threeten.bp.LocalDate;
import org.threeten.bp.OffsetDateTime;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CancelInboundPlanResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CancelSelfShipAppointmentRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CancelSelfShipAppointmentResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ConfirmDeliveryWindowOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ConfirmPackingOptionResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ConfirmPlacementOptionResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ConfirmShipmentContentUpdatePreviewResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ConfirmTransportationOptionsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ConfirmTransportationOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ContentUpdatePreview;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CreateInboundPlanRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CreateInboundPlanResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CreateMarketplaceItemLabelsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.CreateMarketplaceItemLabelsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ErrorList;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateDeliveryWindowOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GeneratePackingOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GeneratePlacementOptionsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GeneratePlacementOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateSelfShipAppointmentSlotsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateSelfShipAppointmentSlotsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateShipmentContentUpdatePreviewsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateShipmentContentUpdatePreviewsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateTransportationOptionsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GenerateTransportationOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GetDeliveryChallanDocumentResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.GetSelfShipAppointmentSlotsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.InboundOperationStatus;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.InboundPlan;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListDeliveryWindowOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListInboundPlanBoxesResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListInboundPlanItemsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListInboundPlanPalletsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListInboundPlansResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListItemComplianceDetailsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListPackingGroupBoxesResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListPackingGroupItemsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListPackingOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListPlacementOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListPrepDetailsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListShipmentBoxesResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListShipmentContentUpdatePreviewsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListShipmentItemsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListShipmentPalletsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ListTransportationOptionsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ScheduleSelfShipAppointmentRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.ScheduleSelfShipAppointmentResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.SetPackingInformationRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.SetPackingInformationResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.SetPrepDetailsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.SetPrepDetailsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.Shipment;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateInboundPlanNameRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateItemComplianceDetailsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateItemComplianceDetailsResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateShipmentNameRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateShipmentSourceAddressRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateShipmentSourceAddressResponse;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateShipmentTrackingDetailsRequest;
import software.amazon.spapi.models.fulfillment.inbound.v2024_03_20.UpdateShipmentTrackingDetailsResponse;
import org.junit.jupiter.api.Test;

import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse.BodyHandlers;
import java.util.*;
import java.util.stream.Collectors;

import static org.junit.jupiter.api.Assertions.*;

public class FbaInboundApiTest {

    private static String endpoint = "http://localhost:3000";
    private static String authEndpoint = "http://localhost:3000/auth/o2/token";
    private static LWAAuthorizationCredentials credentials = LWAAuthorizationCredentials.builder()
        .clientId("clientId")
        .clientSecret("clientSecret")
        .refreshToken("refreshToken")
        .endpoint(authEndpoint)
        .build();

    private final FbaInboundApi api = new FbaInboundApi.Builder()
        .lwaAuthorizationCredentials(credentials)
        .endpoint(endpoint)
        .build();

    private final EasyRandom easyRandom = new EasyRandom(
        new EasyRandomParameters().randomize(OffsetDateTime.class, OffsetDateTime::now)
                .randomize(LocalDate.class, LocalDate::now)
                .collectionSizeRange(1, 2)
    );

    @Test
    public void cancelInboundPlanTest() throws Exception {
        instructBackendMock("cancelInboundPlan", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<CancelInboundPlanResponse> response = api.cancelInboundPlanWithHttpInfo(inboundPlanId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void cancelSelfShipAppointmentTest() throws Exception {
        instructBackendMock("cancelSelfShipAppointment", "202");
        CancelSelfShipAppointmentRequest body = easyRandom.nextObject(CancelSelfShipAppointmentRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<CancelSelfShipAppointmentResponse> response = api.cancelSelfShipAppointmentWithHttpInfo(body, inboundPlanId, shipmentId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void confirmDeliveryWindowOptionsTest() throws Exception {
        instructBackendMock("confirmDeliveryWindowOptions", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);
        String deliveryWindowOptionId = easyRandom.nextObject(String.class);

        ApiResponse<ConfirmDeliveryWindowOptionsResponse> response = api.confirmDeliveryWindowOptionsWithHttpInfo(inboundPlanId, shipmentId, deliveryWindowOptionId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void confirmPackingOptionTest() throws Exception {
        instructBackendMock("confirmPackingOption", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String packingOptionId = easyRandom.nextObject(String.class);

        ApiResponse<ConfirmPackingOptionResponse> response = api.confirmPackingOptionWithHttpInfo(inboundPlanId, packingOptionId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void confirmPlacementOptionTest() throws Exception {
        instructBackendMock("confirmPlacementOption", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String placementOptionId = easyRandom.nextObject(String.class);

        ApiResponse<ConfirmPlacementOptionResponse> response = api.confirmPlacementOptionWithHttpInfo(inboundPlanId, placementOptionId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void confirmShipmentContentUpdatePreviewTest() throws Exception {
        instructBackendMock("confirmShipmentContentUpdatePreview", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);
        String contentUpdatePreviewId = easyRandom.nextObject(String.class);

        ApiResponse<ConfirmShipmentContentUpdatePreviewResponse> response = api.confirmShipmentContentUpdatePreviewWithHttpInfo(inboundPlanId, shipmentId, contentUpdatePreviewId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void confirmTransportationOptionsTest() throws Exception {
        instructBackendMock("confirmTransportationOptions", "202");
        ConfirmTransportationOptionsRequest body = easyRandom.nextObject(ConfirmTransportationOptionsRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ConfirmTransportationOptionsResponse> response = api.confirmTransportationOptionsWithHttpInfo(body, inboundPlanId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void createInboundPlanTest() throws Exception {
        instructBackendMock("createInboundPlan", "202");
        CreateInboundPlanRequest body = easyRandom.nextObject(CreateInboundPlanRequest.class);

        ApiResponse<CreateInboundPlanResponse> response = api.createInboundPlanWithHttpInfo(body);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void createMarketplaceItemLabelsTest() throws Exception {
        instructBackendMock("createMarketplaceItemLabels", "200");
        CreateMarketplaceItemLabelsRequest body = easyRandom.nextObject(CreateMarketplaceItemLabelsRequest.class);

        ApiResponse<CreateMarketplaceItemLabelsResponse> response = api.createMarketplaceItemLabelsWithHttpInfo(body);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void generateDeliveryWindowOptionsTest() throws Exception {
        instructBackendMock("generateDeliveryWindowOptions", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<GenerateDeliveryWindowOptionsResponse> response = api.generateDeliveryWindowOptionsWithHttpInfo(inboundPlanId, shipmentId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void generatePackingOptionsTest() throws Exception {
        instructBackendMock("generatePackingOptions", "202");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<GeneratePackingOptionsResponse> response = api.generatePackingOptionsWithHttpInfo(inboundPlanId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void generatePlacementOptionsTest() throws Exception {
        instructBackendMock("generatePlacementOptions", "202");
        GeneratePlacementOptionsRequest body = easyRandom.nextObject(GeneratePlacementOptionsRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<GeneratePlacementOptionsResponse> response = api.generatePlacementOptionsWithHttpInfo(body, inboundPlanId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void generateSelfShipAppointmentSlotsTest() throws Exception {
        instructBackendMock("generateSelfShipAppointmentSlots", "201");
        GenerateSelfShipAppointmentSlotsRequest body = easyRandom.nextObject(GenerateSelfShipAppointmentSlotsRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<GenerateSelfShipAppointmentSlotsResponse> response = api.generateSelfShipAppointmentSlotsWithHttpInfo(body, inboundPlanId, shipmentId);

        assertEquals(201, response.getStatusCode());
        assertValidResponsePayload(201, response.getData());
    }

    @Test
    public void generateShipmentContentUpdatePreviewsTest() throws Exception {
        instructBackendMock("generateShipmentContentUpdatePreviews", "202");
        GenerateShipmentContentUpdatePreviewsRequest body = easyRandom.nextObject(GenerateShipmentContentUpdatePreviewsRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<GenerateShipmentContentUpdatePreviewsResponse> response = api.generateShipmentContentUpdatePreviewsWithHttpInfo(body, inboundPlanId, shipmentId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void generateTransportationOptionsTest() throws Exception {
        instructBackendMock("generateTransportationOptions", "202");
        GenerateTransportationOptionsRequest body = easyRandom.nextObject(GenerateTransportationOptionsRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<GenerateTransportationOptionsResponse> response = api.generateTransportationOptionsWithHttpInfo(body, inboundPlanId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void getDeliveryChallanDocumentTest() throws Exception {
        instructBackendMock("getDeliveryChallanDocument", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<GetDeliveryChallanDocumentResponse> response = api.getDeliveryChallanDocumentWithHttpInfo(inboundPlanId, shipmentId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void getInboundOperationStatusTest() throws Exception {
        instructBackendMock("getInboundOperationStatus", "200");
        String operationId = easyRandom.nextObject(String.class);

        ApiResponse<InboundOperationStatus> response = api.getInboundOperationStatusWithHttpInfo(operationId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void getInboundPlanTest() throws Exception {
        instructBackendMock("getInboundPlan", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<InboundPlan> response = api.getInboundPlanWithHttpInfo(inboundPlanId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void getSelfShipAppointmentSlotsTest() throws Exception {
        instructBackendMock("getSelfShipAppointmentSlots", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<GetSelfShipAppointmentSlotsResponse> response = api.getSelfShipAppointmentSlotsWithHttpInfo(inboundPlanId, shipmentId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void getShipmentTest() throws Exception {
        instructBackendMock("getShipment", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<Shipment> response = api.getShipmentWithHttpInfo(inboundPlanId, shipmentId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void getShipmentContentUpdatePreviewTest() throws Exception {
        instructBackendMock("getShipmentContentUpdatePreview", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);
        String contentUpdatePreviewId = easyRandom.nextObject(String.class);

        ApiResponse<ContentUpdatePreview> response = api.getShipmentContentUpdatePreviewWithHttpInfo(inboundPlanId, shipmentId, contentUpdatePreviewId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listDeliveryWindowOptionsTest() throws Exception {
        instructBackendMock("listDeliveryWindowOptions", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<ListDeliveryWindowOptionsResponse> response = api.listDeliveryWindowOptionsWithHttpInfo(inboundPlanId, shipmentId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listInboundPlanBoxesTest() throws Exception {
        instructBackendMock("listInboundPlanBoxes", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ListInboundPlanBoxesResponse> response = api.listInboundPlanBoxesWithHttpInfo(inboundPlanId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listInboundPlanItemsTest() throws Exception {
        instructBackendMock("listInboundPlanItems", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ListInboundPlanItemsResponse> response = api.listInboundPlanItemsWithHttpInfo(inboundPlanId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listInboundPlanPalletsTest() throws Exception {
        instructBackendMock("listInboundPlanPallets", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ListInboundPlanPalletsResponse> response = api.listInboundPlanPalletsWithHttpInfo(inboundPlanId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listInboundPlansTest() throws Exception {
        instructBackendMock("listInboundPlans", "200");

        ApiResponse<ListInboundPlansResponse> response = api.listInboundPlansWithHttpInfo(null, null, null, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listItemComplianceDetailsTest() throws Exception {
        instructBackendMock("listItemComplianceDetails", "200");
        List<String> mskus = easyRandom.objects(String.class, 2).collect(Collectors.toList());
        String marketplaceId = easyRandom.nextObject(String.class);

        ApiResponse<ListItemComplianceDetailsResponse> response = api.listItemComplianceDetailsWithHttpInfo(mskus, marketplaceId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listPackingGroupBoxesTest() throws Exception {
        instructBackendMock("listPackingGroupBoxes", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String packingGroupId = easyRandom.nextObject(String.class);

        ApiResponse<ListPackingGroupBoxesResponse> response = api.listPackingGroupBoxesWithHttpInfo(inboundPlanId, packingGroupId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listPackingGroupItemsTest() throws Exception {
        instructBackendMock("listPackingGroupItems", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String packingGroupId = easyRandom.nextObject(String.class);

        ApiResponse<ListPackingGroupItemsResponse> response = api.listPackingGroupItemsWithHttpInfo(inboundPlanId, packingGroupId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listPackingOptionsTest() throws Exception {
        instructBackendMock("listPackingOptions", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ListPackingOptionsResponse> response = api.listPackingOptionsWithHttpInfo(inboundPlanId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listPlacementOptionsTest() throws Exception {
        instructBackendMock("listPlacementOptions", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ListPlacementOptionsResponse> response = api.listPlacementOptionsWithHttpInfo(inboundPlanId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listPrepDetailsTest() throws Exception {
        instructBackendMock("listPrepDetails", "200");
        String marketplaceId = easyRandom.nextObject(String.class);
        List<String> mskus = easyRandom.objects(String.class, 2).collect(Collectors.toList());

        ApiResponse<ListPrepDetailsResponse> response = api.listPrepDetailsWithHttpInfo(marketplaceId, mskus);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listShipmentBoxesTest() throws Exception {
        instructBackendMock("listShipmentBoxes", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<ListShipmentBoxesResponse> response = api.listShipmentBoxesWithHttpInfo(inboundPlanId, shipmentId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listShipmentContentUpdatePreviewsTest() throws Exception {
        instructBackendMock("listShipmentContentUpdatePreviews", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<ListShipmentContentUpdatePreviewsResponse> response = api.listShipmentContentUpdatePreviewsWithHttpInfo(inboundPlanId, shipmentId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listShipmentItemsTest() throws Exception {
        instructBackendMock("listShipmentItems", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<ListShipmentItemsResponse> response = api.listShipmentItemsWithHttpInfo(inboundPlanId, shipmentId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listShipmentPalletsTest() throws Exception {
        instructBackendMock("listShipmentPallets", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<ListShipmentPalletsResponse> response = api.listShipmentPalletsWithHttpInfo(inboundPlanId, shipmentId, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void listTransportationOptionsTest() throws Exception {
        instructBackendMock("listTransportationOptions", "200");
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<ListTransportationOptionsResponse> response = api.listTransportationOptionsWithHttpInfo(inboundPlanId, null, null, null, null);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void scheduleSelfShipAppointmentTest() throws Exception {
        instructBackendMock("scheduleSelfShipAppointment", "200");
        ScheduleSelfShipAppointmentRequest body = easyRandom.nextObject(ScheduleSelfShipAppointmentRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);
        String slotId = easyRandom.nextObject(String.class);

        ApiResponse<ScheduleSelfShipAppointmentResponse> response = api.scheduleSelfShipAppointmentWithHttpInfo(body, inboundPlanId, shipmentId, slotId);

        assertEquals(200, response.getStatusCode());
        assertValidResponsePayload(200, response.getData());
    }

    @Test
    public void setPackingInformationTest() throws Exception {
        instructBackendMock("setPackingInformation", "202");
        SetPackingInformationRequest body = easyRandom.nextObject(SetPackingInformationRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);

        ApiResponse<SetPackingInformationResponse> response = api.setPackingInformationWithHttpInfo(body, inboundPlanId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void setPrepDetailsTest() throws Exception {
        instructBackendMock("setPrepDetails", "202");
        SetPrepDetailsRequest body = easyRandom.nextObject(SetPrepDetailsRequest.class);

        ApiResponse<SetPrepDetailsResponse> response = api.setPrepDetailsWithHttpInfo(body);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void updateInboundPlanNameTest() throws Exception {
        instructBackendMock("updateInboundPlanName", "204");
        UpdateInboundPlanNameRequest body = easyRandom.nextObject(UpdateInboundPlanNameRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);

        api.updateInboundPlanNameWithHttpInfo(body, inboundPlanId);

    }

    @Test
    public void updateItemComplianceDetailsTest() throws Exception {
        instructBackendMock("updateItemComplianceDetails", "202");
        UpdateItemComplianceDetailsRequest body = easyRandom.nextObject(UpdateItemComplianceDetailsRequest.class);
        String marketplaceId = easyRandom.nextObject(String.class);

        ApiResponse<UpdateItemComplianceDetailsResponse> response = api.updateItemComplianceDetailsWithHttpInfo(body, marketplaceId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void updateShipmentNameTest() throws Exception {
        instructBackendMock("updateShipmentName", "204");
        UpdateShipmentNameRequest body = easyRandom.nextObject(UpdateShipmentNameRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        api.updateShipmentNameWithHttpInfo(body, inboundPlanId, shipmentId);

    }

    @Test
    public void updateShipmentSourceAddressTest() throws Exception {
        instructBackendMock("updateShipmentSourceAddress", "202");
        UpdateShipmentSourceAddressRequest body = easyRandom.nextObject(UpdateShipmentSourceAddressRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<UpdateShipmentSourceAddressResponse> response = api.updateShipmentSourceAddressWithHttpInfo(body, inboundPlanId, shipmentId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }

    @Test
    public void updateShipmentTrackingDetailsTest() throws Exception {
        instructBackendMock("updateShipmentTrackingDetails", "202");
        UpdateShipmentTrackingDetailsRequest body = easyRandom.nextObject(UpdateShipmentTrackingDetailsRequest.class);
        String inboundPlanId = easyRandom.nextObject(String.class);
        String shipmentId = easyRandom.nextObject(String.class);

        ApiResponse<UpdateShipmentTrackingDetailsResponse> response = api.updateShipmentTrackingDetailsWithHttpInfo(body, inboundPlanId, shipmentId);

        assertEquals(202, response.getStatusCode());
        assertValidResponsePayload(202, response.getData());
    }


    private void instructBackendMock(String response, String code) throws Exception {
        HttpRequest request = HttpRequest.newBuilder()
              .uri(new URI(endpoint + "/response/" + response + "/code/" + code))
              .POST(HttpRequest.BodyPublishers.noBody())
              .build();

        HttpClient.newHttpClient().send(request, BodyHandlers.discarding());
    }

    private static void assertValidResponsePayload(int statusCode, Object body) {
        if(statusCode != 204) assertNotNull(body);
    }
}
