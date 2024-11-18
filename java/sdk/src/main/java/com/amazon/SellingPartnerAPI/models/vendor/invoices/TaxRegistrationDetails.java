/*
 * Vendor Invoices v1
 * The Selling Partner API for Retail Procurement Payments provides programmatic access to vendors payments data.
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models.vendor.invoices;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * Tax registration details of the entity.
 */
@Schema(description = "Tax registration details of the entity.")


public class TaxRegistrationDetails {
  /**
   * The tax registration type for the entity.
   */
  @JsonAdapter(TaxRegistrationTypeEnum.Adapter.class)
  public enum TaxRegistrationTypeEnum {
    @SerializedName("VAT")
    VAT("VAT"),
    @SerializedName("GST")
    GST("GST");

    private String value;

    TaxRegistrationTypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static TaxRegistrationTypeEnum fromValue(String input) {
      for (TaxRegistrationTypeEnum b : TaxRegistrationTypeEnum.values()) {
        if (b.value.equals(input)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<TaxRegistrationTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final TaxRegistrationTypeEnum enumeration) throws IOException {
        jsonWriter.value(String.valueOf(enumeration.getValue()));
      }

      @Override
      public TaxRegistrationTypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return TaxRegistrationTypeEnum.fromValue((String)(value));
      }
    }
  }  @SerializedName("taxRegistrationType")
  private TaxRegistrationTypeEnum taxRegistrationType = null;

  @SerializedName("taxRegistrationNumber")
  private String taxRegistrationNumber = null;

  public TaxRegistrationDetails taxRegistrationType(TaxRegistrationTypeEnum taxRegistrationType) {
    this.taxRegistrationType = taxRegistrationType;
    return this;
  }

   /**
   * The tax registration type for the entity.
   * @return taxRegistrationType
  **/
  @Schema(required = true, description = "The tax registration type for the entity.")
  public TaxRegistrationTypeEnum getTaxRegistrationType() {
    return taxRegistrationType;
  }

  public void setTaxRegistrationType(TaxRegistrationTypeEnum taxRegistrationType) {
    this.taxRegistrationType = taxRegistrationType;
  }

  public TaxRegistrationDetails taxRegistrationNumber(String taxRegistrationNumber) {
    this.taxRegistrationNumber = taxRegistrationNumber;
    return this;
  }

   /**
   * The tax registration number for the entity. For example, VAT ID, Consumption Tax ID.
   * @return taxRegistrationNumber
  **/
  @Schema(required = true, description = "The tax registration number for the entity. For example, VAT ID, Consumption Tax ID.")
  public String getTaxRegistrationNumber() {
    return taxRegistrationNumber;
  }

  public void setTaxRegistrationNumber(String taxRegistrationNumber) {
    this.taxRegistrationNumber = taxRegistrationNumber;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TaxRegistrationDetails taxRegistrationDetails = (TaxRegistrationDetails) o;
    return Objects.equals(this.taxRegistrationType, taxRegistrationDetails.taxRegistrationType) &&
        Objects.equals(this.taxRegistrationNumber, taxRegistrationDetails.taxRegistrationNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(taxRegistrationType, taxRegistrationNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TaxRegistrationDetails {\n");
    
    sb.append("    taxRegistrationType: ").append(toIndentedString(taxRegistrationType)).append("\n");
    sb.append("    taxRegistrationNumber: ").append(toIndentedString(taxRegistrationNumber)).append("\n");
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
