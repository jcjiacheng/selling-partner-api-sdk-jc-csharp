/*
 * The Selling Partner API for Invoices.
 * Use the Selling Partner API for Invoices to retrieve and manage invoice-related operations, which can help selling partners manage their bookkeeping processes.
 *
 * OpenAPI spec version: 2024-06-19
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models.invoices;

import java.util.Objects;
import java.util.Arrays;
import com.amazon.SellingPartnerAPI.models.invoices.TransactionIdentifier;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.threeten.bp.OffsetDateTime;
/**
 * Provides detailed information about an invoice.
 */
@Schema(description = "Provides detailed information about an invoice.")


public class Invoice {
  @SerializedName("date")
  private OffsetDateTime date = null;

  @SerializedName("errorCode")
  private String errorCode = null;

  @SerializedName("externalInvoiceId")
  private String externalInvoiceId = null;

  @SerializedName("govResponse")
  private String govResponse = null;

  @SerializedName("id")
  private String id = null;

  @SerializedName("invoiceType")
  private String invoiceType = null;

  @SerializedName("series")
  private String series = null;

  @SerializedName("status")
  private String status = null;

  @SerializedName("transactionIds")
  private List<TransactionIdentifier> transactionIds = null;

  @SerializedName("transactionType")
  private String transactionType = null;

  public Invoice date(OffsetDateTime date) {
    this.date = date;
    return this;
  }

   /**
   * The date and time the invoice is issued. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
   * @return date
  **/
  @Schema(description = "The date and time the invoice is issued. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.")
  public OffsetDateTime getDate() {
    return date;
  }

  public void setDate(OffsetDateTime date) {
    this.date = date;
  }

  public Invoice errorCode(String errorCode) {
    this.errorCode = errorCode;
    return this;
  }

   /**
   * If the invoice is in an error state, this attribute displays the error code.
   * @return errorCode
  **/
  @Schema(description = "If the invoice is in an error state, this attribute displays the error code.")
  public String getErrorCode() {
    return errorCode;
  }

  public void setErrorCode(String errorCode) {
    this.errorCode = errorCode;
  }

  public Invoice externalInvoiceId(String externalInvoiceId) {
    this.externalInvoiceId = externalInvoiceId;
    return this;
  }

   /**
   * The invoice identifier that is used by an external party. This is typically the government agency that authorized the invoice.
   * @return externalInvoiceId
  **/
  @Schema(description = "The invoice identifier that is used by an external party. This is typically the government agency that authorized the invoice.")
  public String getExternalInvoiceId() {
    return externalInvoiceId;
  }

  public void setExternalInvoiceId(String externalInvoiceId) {
    this.externalInvoiceId = externalInvoiceId;
  }

  public Invoice govResponse(String govResponse) {
    this.govResponse = govResponse;
    return this;
  }

   /**
   * The response message from the government authority when there is an error during invoice issuance.
   * @return govResponse
  **/
  @Schema(description = "The response message from the government authority when there is an error during invoice issuance.")
  public String getGovResponse() {
    return govResponse;
  }

  public void setGovResponse(String govResponse) {
    this.govResponse = govResponse;
  }

  public Invoice id(String id) {
    this.id = id;
    return this;
  }

   /**
   * The invoice identifier.
   * @return id
  **/
  @Schema(description = "The invoice identifier.")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public Invoice invoiceType(String invoiceType) {
    this.invoiceType = invoiceType;
    return this;
  }

   /**
   * The classification of the invoice type. This varies across marketplaces. Use the &#x60;getInvoicesAttributes&#x60; operation to check &#x60;invoiceType&#x60; options.
   * @return invoiceType
  **/
  @Schema(description = "The classification of the invoice type. This varies across marketplaces. Use the `getInvoicesAttributes` operation to check `invoiceType` options.")
  public String getInvoiceType() {
    return invoiceType;
  }

  public void setInvoiceType(String invoiceType) {
    this.invoiceType = invoiceType;
  }

  public Invoice series(String series) {
    this.series = series;
    return this;
  }

   /**
   * Use this identifier in conjunction with &#x60;externalInvoiceId&#x60; to identify invoices from the same seller.
   * @return series
  **/
  @Schema(description = "Use this identifier in conjunction with `externalInvoiceId` to identify invoices from the same seller.")
  public String getSeries() {
    return series;
  }

  public void setSeries(String series) {
    this.series = series;
  }

  public Invoice status(String status) {
    this.status = status;
    return this;
  }

   /**
   * The invoice status classification. Use the &#x60;getInvoicesAttributes&#x60; operation to check invoice status options.
   * @return status
  **/
  @Schema(description = "The invoice status classification. Use the `getInvoicesAttributes` operation to check invoice status options.")
  public String getStatus() {
    return status;
  }

  public void setStatus(String status) {
    this.status = status;
  }

  public Invoice transactionIds(List<TransactionIdentifier> transactionIds) {
    this.transactionIds = transactionIds;
    return this;
  }

  public Invoice addTransactionIdsItem(TransactionIdentifier transactionIdsItem) {
    if (this.transactionIds == null) {
      this.transactionIds = new ArrayList<TransactionIdentifier>();
    }
    this.transactionIds.add(transactionIdsItem);
    return this;
  }

   /**
   * List with identifiers for the transactions associated to the invoice.
   * @return transactionIds
  **/
  @Schema(description = "List with identifiers for the transactions associated to the invoice.")
  public List<TransactionIdentifier> getTransactionIds() {
    return transactionIds;
  }

  public void setTransactionIds(List<TransactionIdentifier> transactionIds) {
    this.transactionIds = transactionIds;
  }

  public Invoice transactionType(String transactionType) {
    this.transactionType = transactionType;
    return this;
  }

   /**
   * Classification of the transaction that originated this invoice. Use the &#x60;getInvoicesAttributes&#x60; operation to check &#x60;transactionType&#x60; options.
   * @return transactionType
  **/
  @Schema(description = "Classification of the transaction that originated this invoice. Use the `getInvoicesAttributes` operation to check `transactionType` options.")
  public String getTransactionType() {
    return transactionType;
  }

  public void setTransactionType(String transactionType) {
    this.transactionType = transactionType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Invoice invoice = (Invoice) o;
    return Objects.equals(this.date, invoice.date) &&
        Objects.equals(this.errorCode, invoice.errorCode) &&
        Objects.equals(this.externalInvoiceId, invoice.externalInvoiceId) &&
        Objects.equals(this.govResponse, invoice.govResponse) &&
        Objects.equals(this.id, invoice.id) &&
        Objects.equals(this.invoiceType, invoice.invoiceType) &&
        Objects.equals(this.series, invoice.series) &&
        Objects.equals(this.status, invoice.status) &&
        Objects.equals(this.transactionIds, invoice.transactionIds) &&
        Objects.equals(this.transactionType, invoice.transactionType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(date, errorCode, externalInvoiceId, govResponse, id, invoiceType, series, status, transactionIds, transactionType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Invoice {\n");
    
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    errorCode: ").append(toIndentedString(errorCode)).append("\n");
    sb.append("    externalInvoiceId: ").append(toIndentedString(externalInvoiceId)).append("\n");
    sb.append("    govResponse: ").append(toIndentedString(govResponse)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    invoiceType: ").append(toIndentedString(invoiceType)).append("\n");
    sb.append("    series: ").append(toIndentedString(series)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    transactionIds: ").append(toIndentedString(transactionIds)).append("\n");
    sb.append("    transactionType: ").append(toIndentedString(transactionType)).append("\n");
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
