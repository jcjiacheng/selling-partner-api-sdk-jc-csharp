/*
 * Selling Partner API for Orders
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * OpenAPI spec version: v0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.models.orders.v0;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.OffsetDateTime;
/**
 * Information about the prescription that is used to verify a regulated product. This must be provided once per order and reflect the seller’s own records. Only approved orders can have prescriptions.
 */
@Schema(description = "Information about the prescription that is used to verify a regulated product. This must be provided once per order and reflect the seller’s own records. Only approved orders can have prescriptions.")


public class PrescriptionDetail {
  @SerializedName("prescriptionId")
  private String prescriptionId = null;

  @SerializedName("expirationDate")
  private OffsetDateTime expirationDate = null;

  @SerializedName("writtenQuantity")
  private Integer writtenQuantity = null;

  @SerializedName("totalRefillsAuthorized")
  private Integer totalRefillsAuthorized = null;

  @SerializedName("refillsRemaining")
  private Integer refillsRemaining = null;

  @SerializedName("clinicId")
  private String clinicId = null;

  @SerializedName("usageInstructions")
  private String usageInstructions = null;

  public PrescriptionDetail prescriptionId(String prescriptionId) {
    this.prescriptionId = prescriptionId;
    return this;
  }

   /**
   * The identifier for the prescription used to verify the regulated product.
   * @return prescriptionId
  **/
  @Schema(required = true, description = "The identifier for the prescription used to verify the regulated product.")
  public String getPrescriptionId() {
    return prescriptionId;
  }

  public void setPrescriptionId(String prescriptionId) {
    this.prescriptionId = prescriptionId;
  }

  public PrescriptionDetail expirationDate(OffsetDateTime expirationDate) {
    this.expirationDate = expirationDate;
    return this;
  }

   /**
   * The expiration date of the prescription used to verify the regulated product, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format.
   * @return expirationDate
  **/
  @Schema(required = true, description = "The expiration date of the prescription used to verify the regulated product, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format.")
  public OffsetDateTime getExpirationDate() {
    return expirationDate;
  }

  public void setExpirationDate(OffsetDateTime expirationDate) {
    this.expirationDate = expirationDate;
  }

  public PrescriptionDetail writtenQuantity(Integer writtenQuantity) {
    this.writtenQuantity = writtenQuantity;
    return this;
  }

   /**
   * The number of units in each fill as provided in the prescription.
   * minimum: 1
   * @return writtenQuantity
  **/
  @Schema(required = true, description = "The number of units in each fill as provided in the prescription.")
  public Integer getWrittenQuantity() {
    return writtenQuantity;
  }

  public void setWrittenQuantity(Integer writtenQuantity) {
    this.writtenQuantity = writtenQuantity;
  }

  public PrescriptionDetail totalRefillsAuthorized(Integer totalRefillsAuthorized) {
    this.totalRefillsAuthorized = totalRefillsAuthorized;
    return this;
  }

   /**
   * The total number of refills written in the original prescription used to verify the regulated product. If a prescription originally had no refills, this value must be 0.
   * minimum: 0
   * @return totalRefillsAuthorized
  **/
  @Schema(required = true, description = "The total number of refills written in the original prescription used to verify the regulated product. If a prescription originally had no refills, this value must be 0.")
  public Integer getTotalRefillsAuthorized() {
    return totalRefillsAuthorized;
  }

  public void setTotalRefillsAuthorized(Integer totalRefillsAuthorized) {
    this.totalRefillsAuthorized = totalRefillsAuthorized;
  }

  public PrescriptionDetail refillsRemaining(Integer refillsRemaining) {
    this.refillsRemaining = refillsRemaining;
    return this;
  }

   /**
   * The number of refills remaining for the prescription used to verify the regulated product. If a prescription originally had 10 total refills, this value must be &#x60;10&#x60; for the first order, &#x60;9&#x60; for the second order, and &#x60;0&#x60; for the eleventh order. If a prescription originally had no refills, this value must be 0.
   * minimum: 0
   * @return refillsRemaining
  **/
  @Schema(required = true, description = "The number of refills remaining for the prescription used to verify the regulated product. If a prescription originally had 10 total refills, this value must be `10` for the first order, `9` for the second order, and `0` for the eleventh order. If a prescription originally had no refills, this value must be 0.")
  public Integer getRefillsRemaining() {
    return refillsRemaining;
  }

  public void setRefillsRemaining(Integer refillsRemaining) {
    this.refillsRemaining = refillsRemaining;
  }

  public PrescriptionDetail clinicId(String clinicId) {
    this.clinicId = clinicId;
    return this;
  }

   /**
   * The identifier for the clinic which provided the prescription used to verify the regulated product.
   * @return clinicId
  **/
  @Schema(required = true, description = "The identifier for the clinic which provided the prescription used to verify the regulated product.")
  public String getClinicId() {
    return clinicId;
  }

  public void setClinicId(String clinicId) {
    this.clinicId = clinicId;
  }

  public PrescriptionDetail usageInstructions(String usageInstructions) {
    this.usageInstructions = usageInstructions;
    return this;
  }

   /**
   * The instructions for the prescription as provided by the approver of the regulated product.
   * @return usageInstructions
  **/
  @Schema(required = true, description = "The instructions for the prescription as provided by the approver of the regulated product.")
  public String getUsageInstructions() {
    return usageInstructions;
  }

  public void setUsageInstructions(String usageInstructions) {
    this.usageInstructions = usageInstructions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PrescriptionDetail prescriptionDetail = (PrescriptionDetail) o;
    return Objects.equals(this.prescriptionId, prescriptionDetail.prescriptionId) &&
        Objects.equals(this.expirationDate, prescriptionDetail.expirationDate) &&
        Objects.equals(this.writtenQuantity, prescriptionDetail.writtenQuantity) &&
        Objects.equals(this.totalRefillsAuthorized, prescriptionDetail.totalRefillsAuthorized) &&
        Objects.equals(this.refillsRemaining, prescriptionDetail.refillsRemaining) &&
        Objects.equals(this.clinicId, prescriptionDetail.clinicId) &&
        Objects.equals(this.usageInstructions, prescriptionDetail.usageInstructions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(prescriptionId, expirationDate, writtenQuantity, totalRefillsAuthorized, refillsRemaining, clinicId, usageInstructions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PrescriptionDetail {\n");
    
    sb.append("    prescriptionId: ").append(toIndentedString(prescriptionId)).append("\n");
    sb.append("    expirationDate: ").append(toIndentedString(expirationDate)).append("\n");
    sb.append("    writtenQuantity: ").append(toIndentedString(writtenQuantity)).append("\n");
    sb.append("    totalRefillsAuthorized: ").append(toIndentedString(totalRefillsAuthorized)).append("\n");
    sb.append("    refillsRemaining: ").append(toIndentedString(refillsRemaining)).append("\n");
    sb.append("    clinicId: ").append(toIndentedString(clinicId)).append("\n");
    sb.append("    usageInstructions: ").append(toIndentedString(usageInstructions)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
